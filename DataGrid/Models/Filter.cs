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
        public int LogicalOperator { get; protected set; } = 0;
        public Filter(string _column, string _operator, string _filteredValue, int _logicalOperator) 
        { 
            Column = _column;
            Operator = _operator;
            FilterValue = _filteredValue;
            LogicalOperator = _logicalOperator;
        }

        public string FilterString()
        {
            string filterSring = "";
            switch(LogicalOperator)
            {
                case -1: filterSring = "" + " " + $"[{Column}]" + Operator + FilterValue; break;
                case 0 : filterSring = "" + " " + $"[{Column}]" + Operator + FilterValue; break;
                case 1 : filterSring = " AND" + " " + $"[{Column}]" + Operator + FilterValue; break;
                case 2: filterSring = " OR" + " " + $"[{Column}]" + Operator + FilterValue; break;
            }
            return filterSring;
        }
    }
}
