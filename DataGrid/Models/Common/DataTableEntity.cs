using DataGrid.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid.Models.Common
{
    public abstract class DataTableEntity
    {
        public List<DataColumn> headers { get; protected set; }
        public DataTable dataTable { get; protected set; }

        private IInputFileReaderService inputFileReaderService;

        public DataTableEntity(IInputFileReaderService _inputFileReaderService) {
            inputFileReaderService = _inputFileReaderService;
        }

        public void ImportFile() { 
            dataTable = inputFileReaderService.ReadFile();
            var _headers = new List<DataColumn>();
            for (int i = 0; i<dataTable.Columns.Count; i++)
            {
                _headers.Add(dataTable.Columns[i]);
            }
            headers = _headers;
        }
    }
}
