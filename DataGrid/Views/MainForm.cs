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
        FilteredDataTable filteredDataTable;
        public MainForm(IInputFileReaderService _fileReaderService)
        {
            fileReaderService = _fileReaderService;  
            filteredDataTable = new FilteredDataTable(fileReaderService);
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filteredDataTable.ImportFile(); 
            dataGridView.DataSource = filteredDataTable.dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = true;

            List<string> headers = new List<string>() {"Criteria"};
            if (filteredDataTable.headers == null) return;
            filteredDataTable.headers.ForEach(col =>
            {
                if (col.DataType == typeof(string)) return;
                headers.Add(col.ColumnName);
            });
            criteriaDropDown.DataSource = headers;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (criteriaDropDown.SelectedIndex == 0) return;
            operatorsDropDown.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (criteriaDropDown.SelectedIndex == 0) { MessageBox.Show("Criteria Must be Selected!"); return; }
            if (operatorsDropDown.SelectedIndex == 0) { MessageBox.Show("Operator Must be Selected"); return; }
            if (filterTextBox.Text == "") { MessageBox.Show("Value Must be Added"); return; }
            if (andOrDropDow.SelectedIndex == -1 && filteredDataTable.Filters.Count>0) { MessageBox.Show("Logical Operator Must be Selected"); return; }

            Filter filter = new Filter(criteriaDropDown.Text, operatorsDropDown.Text, filterTextBox.Text, andOrDropDow.SelectedIndex);
            filteredDataTable.Filters.Add(filter);
            filterEditor.Text += filter.FilterString();
            if (filteredDataTable.Filters.Count == 0) return;
            andOrDropDow.Enabled = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dataGridView.DataSource = filteredDataTable.ApplyFilters(dataGridView, filterEditor.Text);
        }

        private void operatorsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operatorsDropDown.SelectedIndex == 0) return;
            filterTextBox.Enabled = true;
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (filterTextBox.Text == "" || filteredDataTable.Filters.Count==0) return;
            andOrDropDow.Enabled = true;
        }
    }
}
