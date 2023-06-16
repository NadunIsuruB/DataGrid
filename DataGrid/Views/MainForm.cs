using DataGrid.Models.Interfaces;
using System;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class MainForm : Form
    {
        IInputFileReaderService fileReaderService;
        public MainForm(IInputFileReaderService _fileReaderService)
        {
            fileReaderService = _fileReaderService;  
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
            var dataTable = fileReaderService.ReadFile();
            dataGridView.DataSource = dataTable;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
