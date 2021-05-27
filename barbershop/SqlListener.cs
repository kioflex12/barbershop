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
        private static readonly string datePattern = "dd.MM.yyyy";

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
                    if (DateTime.TryParse(reader[i].ToString(), out var tempDate))
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

        

       

        public static void ExecuteQuery(string query)
        {
            MySqlCommand sqlCommand = new MySqlCommand(query, _sqlConnection);

            sqlCommand.ExecuteNonQuery();
        }
    }
}
