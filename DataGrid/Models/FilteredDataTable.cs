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
        public List<Filter> Filters = new List<Filter>();
        public FilteredDataTable(IInputFileReaderService inputFileReaderService): base(inputFileReaderService)
        {

        }

        public BindingSource ApplyFilters(DataGridView dataGridView)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dataGridView.DataSource;

            Filters.ForEach(f => {
                bs.Filter += f.FilterString();
            });

            return bs;
        }

    }
}
