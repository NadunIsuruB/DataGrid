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
        public string SearchString { get; set; } = "";
        private BindingSource bindingSource = new BindingSource();
        public FilteredDataTable(IInputFileReaderService inputFileReaderService): base(inputFileReaderService)
        {

        }

        public BindingSource ApplyFilters(string filterString)
        {
            
            try
            {
                bindingSource.DataSource = DataTable;
                bindingSource.Filter = "";
                
                FilterString = filterString;
                if(filterString == "") return bindingSource;
                if(SearchString == "")
                {
                    bindingSource.Filter = FilterString;
                }
                else
                {
                    bindingSource.Filter = FilterString + " AND " + SearchString;
                }
                 
                
            }catch(Exception ex)
            {
                MessageBox.Show("Please Enter Correct Filter Criterias!");
            }
            return bindingSource;

        }

        public BindingSource ApplySearch(string searchString)
        {
            try
            {
                bindingSource.DataSource = DataTable;
                bindingSource.Filter = "";

                SearchString = searchString;

                if (FilterString == "")
                {
                    bindingSource.Filter = SearchString;
                }
                else
                {
                    bindingSource.Filter = FilterString + " AND " + SearchString;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something Went Wrong With Searching!");
            }
            return bindingSource;
        }
    }
}
