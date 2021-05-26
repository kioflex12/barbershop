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
        private static SqlConnection _sqlConnection;
        private static List<DataGridView> _dataGridViews;

        public static void InitConnection()
        {
            string BDpath = Application.StartupPath + @"\barbershop.mdf" ;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + BDpath + ";Integrated Security=True";
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
        }

        public static void SetDataAdditictions(List<DataGridView> dataGridViews)
        {
            _dataGridViews = dataGridViews;
            UpdateDataGridViews();
        }

        public static void UpdateDataGridViews()
        {
            foreach (var dataGrid in _dataGridViews)
            {
                dataGrid.Rows.Clear();
                string query = $"select * from {dataGrid.Name}";
                SqlCommand sqlCommand = new SqlCommand(query,_sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[reader.FieldCount]);
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        data[data.Count - 1][i] = reader[i].ToString();
                    }
                }

                reader.Close();

                foreach (string[] s in data)
                {
                    dataGrid.Rows.Add(s);
                }

            }
        }

        public static void Insert(DataGridView table, DataGridViewRow row)
        {
           

            //SqlCommand sqlCommand = _sqlConnection.CreateCommand();
            //sqlCommand.CommandType = CommandType.Text;
            string values = "";
            int result;
            foreach (DataGridViewTextBoxCell item in row.Cells)
            {
                if (Int32.TryParse(item.Value.ToString(),out result))
                {
                    values += $"{result},";
                }
                else 
                    values += $"'{item.Value}',";
            }
            SqlCommand sqlCommand = new SqlCommand(values, _sqlConnection);

            values = values.Remove(values.Length-1);
            sqlCommand.CommandText = $"insert into {table.Name} values ({values});";
           
            var numberStrings = sqlCommand.ExecuteNonQuery();
            UpdateDataGridViews();
            MessageBox.Show($"Успешно добавлено {numberStrings} строк");
            

        }
    }
}
