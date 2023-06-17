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
        public List<DataColumn> Headers { get; protected set; }
        public DataTable DataTable { get; protected set; }

        private IInputFileReaderService inputFileReaderService;

        public DataTableEntity(IInputFileReaderService _inputFileReaderService) {
            inputFileReaderService = _inputFileReaderService;
        }

        public void ImportFile() {
            try
            {
                DataTable = inputFileReaderService.ReadFile();
                var _headers = new List<DataColumn>();
                if (DataTable == null) throw new Exception("Data Table Not Found!");
                for (int i = 0; i < DataTable.Columns.Count; i++)
                {
                    _headers.Add(DataTable.Columns[i]);
                }
                Headers = _headers;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
