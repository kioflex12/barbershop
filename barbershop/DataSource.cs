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
       
        /// <summary>
        /// Устанавливает словарь таблиц 
        /// </summary>
        /// <param name="tablesData"></param>
        public static void SetupTablesData(Dictionary<ActiveTables, TableDataSource.TableData> tablesData)
        {
            tables = tablesData;
            
            UpdateDataGridViews();
        }

        /// <summary>
        /// Обновляет все datagridview на форме
        /// </summary>
        public static void UpdateDataGridViews()
        {
            foreach (var table in tables.Values)
            {
                table.TableSource.JoinDataGrid.Rows.Clear();

                var data = SqlListener.GetQueryResult(table.TableSource.SelectCommand);
               
                
                foreach (string[] s in data)
                {
                    table.TableSource.JoinDataGrid.Rows.Add(s);
                }
                

            }
        }
        
    }
}
