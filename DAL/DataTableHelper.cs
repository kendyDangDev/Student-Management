using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataTableHelper
    {
        /*
         int currentPage = 0;
        int totalItems = ...;
        int itemPerPage = 10;
        int totalPage = Math.Ceiling((double)totalItems/itemPerPage);

        void NextPage(){
            var datas = GetDataTable();
            res =  datas.SkipRows(currentPage*ItemPerPage).GetRows(ItemPerPage)
            currentPage++;
            dgv = res;
        }
         */
        public static DataTable GetRows(this DataTable table, int rows)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < rows; i++)
            {
                dt.Rows.Add(table.Rows[i]);
            }
            return dt;
        }
        public static DataTable SkipRows(this DataTable table,int rows) 
        {
            DataTable result = new DataTable();
            for(int i = rows+1;i< table.Rows.Count;i++)
            {
                result.Rows.Add(table.Rows[i]);
            }
            return result;
        }
    }
}
