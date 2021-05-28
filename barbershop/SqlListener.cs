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
        private static readonly string _datePattern = "dd.MM.yyyy";

        public static bool ConnectionIsStablish => _sqlConnection != null;
        /// <summary>
        /// Устанавливает соединение
        /// </summary>
        public static bool InitConnection(string connectionString)
        {
            try
            {
                _sqlConnection = new MySqlConnection(connectionString);
                _sqlConnection.Open();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        /// <summary>
        /// Получает столбца заданной таблицы
        /// </summary>
        /// <param name="Table"></param>
        /// <returns></returns>
        public static List<string[]> GetTableColumns(string Table)
        {
            string getTypeColumnsCommand = @"select COLUMN_NAME, DATA_TYPE
                                            from INFORMATION_SCHEMA.COLUMNS
                                            where TABLE_NAME =" + $"'{Table}' group by column_name";

            return SqlListener.GetQueryResult(getTypeColumnsCommand);
        }

        /// <summary>
        /// Получает результат выполнения sql запроса
        /// </summary>
        /// <param name="query">sql запрос</param>
        /// <returns></returns>
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
                        data[data.Count - 1][i] = $"'{tempDate.ToString(_datePattern)}";
                    }
                    else
                        data[data.Count - 1][i] = reader[i].ToString();
                }
            }

            reader.Close();
            return data;
        }

        /// <summary>
        /// Выполняет sql команду
        /// </summary>
        /// <param name="query">sql команда</param>
        public static void ExecuteQuery(string query)
        {
            MySqlCommand sqlCommand = new MySqlCommand(query, _sqlConnection);

            sqlCommand.ExecuteNonQuery();
        }
    }
}
