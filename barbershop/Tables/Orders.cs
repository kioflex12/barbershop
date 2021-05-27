using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop.Tables
{
    class Orders : Table
    {
        public Orders(DataGridView dataGrid) : base(dataGrid)
        {
        }

        public override string UpdateCommand => @"SELECT orders.id_order, services.full_name, services.price, clients.full_name, orders.date_of_service, masters.full_name AS master
                                                  FROM orders 
                                                  INNER JOIN services 
                                                  ON 
                                                  orders.id_service = services.id_service 
                                                  INNER JOIN masters 
                                                  ON 
                                                  orders.id_master = masters.id_master 
                                                  INNER JOIN clients 
                                                  ON 
                                                  orders.id_client = clients.id_client";


        public override List<DataGridViewColumn> GetColumnForDataGridView(ActiveTables table)
        {
            var tableName = Tables.EnumConverter.EnumToString(table);
            List<DataGridViewColumn> dataGridViewcolumns = new List<DataGridViewColumn>();
            var columns = SqlListener.GetTableColumns(tableName) ;
            for (int i = 1; i < columns.Count; i++)
            {
                string columName = columns[i][0];
                var parsedName = columns[i][0].Split('_');

                if ((parsedName.Count() > 1) && (Enum.TryParse<ActiveTables>(parsedName[1]+"s", out var tableFromId)))
                {
                    string getCollectionCommand = $"select full_name from {tableFromId} ";
                    var column = new DataGridViewComboBoxColumn() { Name = columName };
                    
                    foreach (var item in SqlListener.GetQueryResult(getCollectionCommand))
                    {
                        column.Items.AddRange(item);
                        
                    }
                    dataGridViewcolumns.Add(column);
                }
                else
                    dataGridViewcolumns.Add(new DataGridViewTextBoxColumn() { Name = columName, HeaderText = columName });
            }
            return dataGridViewcolumns;
        }

      
    }
}
