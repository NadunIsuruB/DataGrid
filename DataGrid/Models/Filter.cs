using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Models
{
    public class Filter
    {
        public string Column { get; protected set; }
        public string Operator { get; protected set; }
        public string FilterValue { get; protected set; }
        public string LogicalOperator { get; protected set; } = string.Empty;
        public Filter(string _column, string _operator, string _filteredValue, string _fogicalOperator) 
        { 
            Column = _column;
            Operator = _operator;
            FilterValue = _filteredValue;
            LogicalOperator = _fogicalOperator;
        }

        public string FilterString()
        {
            return LogicalOperator +" "+ $"[{Column}]" + Operator + FilterValue;
        }
    }
}
