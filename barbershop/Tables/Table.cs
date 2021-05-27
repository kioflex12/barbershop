using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop.Tables
{
    public class Table
    {
        public DataGridView JoinDataGrid { get; set; }

        public Table(DataGridView dataGrid)
        {
            JoinDataGrid = dataGrid;
        }
        
        public virtual string UpdateCommand { get;  }

        public virtual List<DataGridViewColumn> GetColumnForDataGridView(ActiveTables table)
        {
            List<DataGridViewColumn> dataGridViewcolumns = new List<DataGridViewColumn>();
            var columns = SqlListener.GetTableColumns(Tables.EnumConverter.EnumToString(table));
            for (int i = 1; i < columns.Count; i++)
            {
                string columName = columns[i][0];
                dataGridViewcolumns.Add(new DataGridViewTextBoxColumn() { Name = columName, HeaderText = columName });
            }
            return dataGridViewcolumns;
        }

        public string GetInsertString(DataGridViewRow row, ActiveTables table)
        {
            string tableName = EnumConverter.EnumToString(table);


            var dataTypes = SqlListener.GetTableColumns(tableName);
            dataTypes.RemoveAt(0);
            string columns = "";


            for (int i = 0; i < dataTypes.Count; i++)
            {
                columns += $"{ dataTypes[i][0]}";
                if (dataTypes[i] != dataTypes.Last())
                {
                    columns += ",";
                }
            }
            string insertString = $"insert into {tableName}({columns}) values (";
            for (int i = 0; i < dataTypes.Count(); i++)
            {
                string value = row.Cells[i].Tag != null ? row.Cells[i].Tag.ToString() : row.Cells[i].Value.ToString();

                switch (dataTypes[i][1].ToString())
                {
                    case "int":
                        if (!Int32.TryParse(value, out var result))
                            return null;

                        insertString += result;
                        break;

                    case "date":
                        if (!DateTime.TryParse(value, out var date))
                            return null;

                        insertString += $"'{date:yyyy.MM.dd}'";
                        break;

                    case "varchar":
                        insertString += $"'{value}'";
                        break;
                }
                if (i == dataTypes.Count() - 1)
                {
                    insertString += ")";
                }
                else
                    insertString += ",";
            }
            return insertString;
        }

        public string GetDeleteString( string key, ActiveTables table)
        {
            var tableName = EnumConverter.EnumToString(table);
            var columns = SqlListener.GetTableColumns(tableName);
            return $"delete from {tableName} where {columns[0][0]}='{key}'";

        }
    }
}
