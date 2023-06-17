using DataGrid.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Services
{
    public class FilterService : IFilterService
    {
        public string Column { get; set; }
        public string Operator { get; set; }
        public string FilterValue { get; set; }
        public int LogicalOperator { get; set; } = 0;

        public string FilterString()
        {
            string filterSring = "";
            switch (LogicalOperator)
            {
                case -1: filterSring = "" + $"[{Column}]" + Operator + FilterValue; break;
                case 0: filterSring = " AND " + $"[{Column}]" + Operator + FilterValue; break;
                case 1: filterSring = " OR " + $"[{Column}]" + Operator + FilterValue; break;
            }
            return filterSring;
        }
    }
}
