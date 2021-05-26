using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using barbershop.Tables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace barbershop
{
    public static class SqlListener
    {

        private static MySqlConnection _sqlConnection;
        private static string datePattern = "dd.MM.yyyy";

        public static void InitConnection()
        {
            string connectionString = @"server = localhost; user id = root;  database = barbershop; password=123; pooling = false; convert zero datetime=true";
            
            _sqlConnection = new MySqlConnection(connectionString);
            _sqlConnection.Open();
        }

        public static List<string[]> GetTableColumns(string Table)
        {
            string getTypeColumnsCommand = @"select COLUMN_NAME, DATA_TYPE
                                            from INFORMATION_SCHEMA.COLUMNS
                                            where TABLE_NAME =" + $"'{Table}'";

            return SqlListener.GetQueryResult(getTypeColumnsCommand);
        }

        public static List<string[]> GetQueryResult(string query)
        {

            MySqlCommand sqlCommand = new MySqlCommand(query, _sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    //var type = reader[i].GetType();
                    if (DateTime.TryParse(reader[i].ToString(),out var tempDate))
                    {
                        data[data.Count - 1][i] = $"'{tempDate.ToString(datePattern)}";
                    }
                    else
                        data[data.Count - 1][i] = reader[i].ToString();
                }
            }

            reader.Close();
            return data;
        }
        
        public static string GetInsertString(DataGridViewRow row, ActiveTables table)
        {
            string tableName = EnumConverter.EnumToString(table);


            var dataTypes = GetTableColumns(tableName);
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
                switch (dataTypes[i][1].ToString())
                {
                    case "int":
                        insertString += row.Cells[i].Value.ToString();
                        break;
                    case "date":
                        if (DateTime.TryParse(row.Cells[i].Value.ToString(),out var date))
                        {
                            insertString += $"'{date:yyyy.MM.dd}'";
                        }
                        else
                        {
                            return null;
                        }
                        break;
                    case "varchar":
                        insertString += $"'{row.Cells[i].Value}'";
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

        public static string GetDeleteString(ActiveTables table, string key)
        {
            var tableName = EnumConverter.EnumToString(table);
            var columns = GetTableColumns(tableName);
            return $"delete from {tableName} where {columns[0][0]}='{key}'";
           
        }

        public static void ExecuteQuery(string query)
        {
            MySqlCommand sqlCommand = new MySqlCommand(query, _sqlConnection);

            sqlCommand.ExecuteNonQuery();
        }
    }
}
