using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Models.Interfaces
{
    public interface IInputFileReaderService
    {
        string FilePath { get; }
        DataTable DataTable { get; set; }
        DataTable ReadFile();
    }
}
