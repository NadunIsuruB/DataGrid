using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
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
            OpenFileDialog opf  = new OpenFileDialog();
            opf.Filter = "csv File|*.csv";
            var dataTable = new DataTable();

            if (opf.ShowDialog() == DialogResult.OK)
            {
                string[] lins = System.IO.File.ReadAllLines(opf.FileName);
                string[][] data = new string[lins.Length][];
                for(int i = 0; i<lins.Length; i++)
                {
                    data[i] = lins[i].Split(',');
                    if(i == 0)
                    {
                        foreach(string s in data[i])
                        {
                            dataTable.Columns.Add(s);
                        }
                    }
                    else
                    {
                        dataTable.NewRow();
                        dataTable.Rows.Add(data[i]);
                    }
                    
                }

                
                dataGridView.DataSource = dataTable;
                dataGridView.ReadOnly = true;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
