using DataGrid.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace DataGrid.Services
{
    public class CSVReaderService : IInputFileReaderService
    {
        public string FilePath { get; protected set; }

        public DataTable DataTable { get; set; }

        public DataTable ReadFile()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "csv File|*.csv";
            var dataTable = new DataTable();

            if (opf.ShowDialog() != DialogResult.OK) return null;

            string[] lines = System.IO.File.ReadAllLines(opf.FileName);
            FilePath = opf.FileName;
            string[][] data = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                data[i] = lines[i].Split(',');
                if (i == 0)
                {
                    foreach (string col in data[i])
                    {
                        bool isInteger = true;
                        foreach (string value in File.ReadLines(FilePath).Skip(1).Take(6))
                        {
                            if (!int.TryParse(value.Split(',')[data[i].ToList().IndexOf(col)], out _))
                            {
                                isInteger = false;
                                break;
                            }
                        }
                        if (isInteger)
                        {
                            dataTable.Columns.Add(col, typeof(int));
                        }
                        else
                        {
                            dataTable.Columns.Add(col, typeof(string));
                        }
                        
                    }
                }
                else
                {
                    dataTable.NewRow();
                    dataTable.Rows.Add(data[i]);
                }
            }
            this.DataTable = dataTable;
            return dataTable;

        }
    }
}
