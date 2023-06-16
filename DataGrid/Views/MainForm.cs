using DataGrid.Models;
using DataGrid.Models.Interfaces;
using System;
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
            dataGridView.DataSource= "Madun";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filteredDataTable.ImportFile();
            var dataTable = filteredDataTable.dataTable;
            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = true;

            criteriaDropDown.DataSource = filteredDataTable.headers;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(filteredDataTable.headers[1]);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
