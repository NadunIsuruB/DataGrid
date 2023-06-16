using DataGrid.Models.Common;
using DataGrid.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Models
{
    public class FilteredDataTable : DataTableEntity
    {
        public FilteredDataTable(IInputFileReaderService inputFileReaderService): base(inputFileReaderService)
        {

        }

    }
}
