using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Models.Interfaces
{
    public interface IFilterService
    {
        string Column { get; set; }
        string Operator { get; set; }
        string FilterValue { get; set; }
        int LogicalOperator { get; set; }

        string FilterString();
        string SearchString(List<DataColumn> columns, string searchParam);
    }
}
