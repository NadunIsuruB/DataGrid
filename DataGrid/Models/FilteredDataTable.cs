using DataGrid.Models.Common;
using DataGrid.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid.Models
{
    public class FilteredDataTable : DataTableEntity
    {
        //public List<Filter> Filters = new List<Filter>();
        public string FilterString { get; set; } = "";
        public FilteredDataTable(IInputFileReaderService inputFileReaderService): base(inputFileReaderService)
        {

        }

        public BindingSource ApplyFilters(DataGridView dataGridView, string filterString)
        {
            BindingSource bs = new BindingSource();
            try
            {
                bs.DataSource = dataGridView.DataSource;

                bs.Filter = filterString;
                
                FilterString = filterString;

                return bs;
            }catch(Exception ex)
            {
                MessageBox.Show("Please Enter Correct Filter Criterias!");
                return bs;
            }
            
        }

    }
}
