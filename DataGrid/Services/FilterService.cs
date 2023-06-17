using DataGrid.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
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

        public string SearchString(List<DataColumn> columns ,string searchParam)
        {
            if (columns.Count <= 0 || searchParam == "") return "";

            string searchString = "";

            columns.ForEach(col =>
            {
                if(col.DataType == typeof(string))
                {
                    if(searchString.Length <= 0)
                    {
                        searchString = $"[{col.ColumnName}]" + " like '%" + searchParam + "%'";
                    }
                    else
                    {
                        searchString += " OR "+$"[{col.ColumnName}]" + " like '%" + searchParam + "%'";
                    }
                }
            });

            return searchString;
        }
    }
}
