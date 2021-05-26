using barbershop.Tables;
using barbershop.Tables.DataSource;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop
{
    static class DataSource
    {
        public static Dictionary<ActiveTables, TableDataSource.TableData> tables;
       

        public static void SetDataAdditictions(Dictionary<ActiveTables, TableDataSource.TableData> tableDatas)
        {
            tables = tableDatas;
            
            UpdateDataGridViews();
        }

        public static void UpdateDataGridViews()
        {
            foreach (var table in tables.Values)
            {
                table.TableSource.JoinDataGrid.Rows.Clear();

                var data = SqlListener.GetQueryResult(table.TableSource.UpdateCommand);
               
                
                foreach (string[] s in data)
                {
                    table.TableSource.JoinDataGrid.Rows.Add(s);
                }
                

            }
        }

        public static void Insert(string sqlString)
        {
            SqlListener.ExecuteQuery(sqlString);
            UpdateDataGridViews();
        }
    }
}
