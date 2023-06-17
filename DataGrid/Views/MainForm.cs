using DataGrid.Models;
using DataGrid.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class MainForm : Form
    {
        IInputFileReaderService fileReaderService;
        IFilterService filterService;
        FilteredDataTable filteredDataTable;
        public MainForm(IInputFileReaderService _fileReaderService, IFilterService _filterService)
        {
            fileReaderService = _fileReaderService;  
            filterService = _filterService;
            filteredDataTable = new FilteredDataTable(fileReaderService);
            InitializeComponent();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filteredDataTable.ImportFile(); 
            dataGridView.DataSource = filteredDataTable.DataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = true;

            List<string> headers = new List<string>() {"Criteria"};
            if (filteredDataTable.Headers == null) return;
            filteredDataTable.Headers.ForEach(col =>
            {
                if (col.DataType == typeof(string)) return;
                headers.Add(col.ColumnName);
            });
            criteriaDropDown.DataSource = headers;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Criteria Dropdown Click
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (criteriaDropDown.SelectedIndex == 0) return;
            operatorsDropDown.Enabled = true;
        }

        //Operator DropDown Click
        private void operatorsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operatorsDropDown.SelectedIndex == 0) return;
            filterTextBox.Enabled = true;
        }

        //Filter Text Box Click
        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (filterTextBox.Text == "" || filteredDataTable.FilterString == "") return;
            andOrDropDow.Enabled = true;
        }


        //Add Filter Button Click
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (criteriaDropDown.SelectedIndex == 0) { MessageBox.Show("Criteria Must be Selected!"); return; }
            if (operatorsDropDown.SelectedIndex == 0) { MessageBox.Show("Operator Must be Selected"); return; }
            if (filterTextBox.Text == "") { MessageBox.Show("Value Must be Added"); return; }
            if (andOrDropDow.SelectedIndex <= 0 && (filteredDataTable.FilterString != "" || filterEditor.Text != "")) { MessageBox.Show("Logical Operator Must be Selected"); return; }

            //Filter filter = new Filter(criteriaDropDown.Text, operatorsDropDown.Text, filterTextBox.Text, andOrDropDow.SelectedIndex);
            filterService.Column = criteriaDropDown.Text;
            filterService.Operator = operatorsDropDown.Text;
            filterService.FilterValue = filterTextBox.Text;
            filterService.LogicalOperator = andOrDropDow.SelectedIndex;

            filterEditor.Text += filterService.FilterString();
            filteredDataTable.FilterString = filterEditor.Text;
            if (filteredDataTable.FilterString == "") return;
            andOrDropDow.Enabled = true;

        }

        //Filter Button Click
        private void button1_Click_2(object sender, EventArgs e)
        {
            dataGridView.DataSource = filteredDataTable.ApplyFilters(filterEditor.Text);
        }

        //Reset Filter Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            filterEditor.Text = "";
            filteredDataTable.FilterString = "";
            searchTextBox.Text = "";
            andOrDropDow.Text = "ADD/OR";

            dataGridView.DataSource = filteredDataTable.ApplyFilters("");
            dataGridView.DataSource = filteredDataTable.ApplySearch("");
        }

        //Filter Editor Text Field Click
        private void filterEditor_TextChanged(object sender, EventArgs e)
        {
            if (filterEditor.Text == "")
            {
                filteredDataTable.FilterString = "";
                andOrDropDow.Enabled = false;
            }
            else
            {
                andOrDropDow.Enabled = true;
            }  
        }

        //search Button
        private void seachButtoon_Click(object sender, EventArgs e)
        {
            string searchStrign = filterService.SearchString(filteredDataTable.Headers, searchTextBox.Text);
            dataGridView.DataSource = filteredDataTable.ApplySearch(searchStrign);
        }
    }
}
