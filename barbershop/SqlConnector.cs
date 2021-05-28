using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop
{
    public partial class SqlConnector : Form
    {

        private IEnumerable<TextBox> _textBoxes;
        public SqlConnector()
        {
            InitializeComponent();
            _textBoxes = Controls.OfType<TextBox>();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            foreach (var textBox in _textBoxes.Reverse())
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    errorProvider.SetError(textBox, "Обязательное поле");
                    return;
                }

                if (textBox.Name == PortTextBox.Name && !UInt32.TryParse(textBox.Text, out _))
                {
                    errorProvider.SetError(textBox, "Некорректный ввод");
                    return;
                }
            }
            if (SqlListener.InitConnection(GetStringConnection()))
            {
                Close();
                
            }
            else
                errorProvider.SetError(ConnectButton, "Не удалось установить соединение");
        }

        private string GetStringConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            #region настройки подключения
            builder.Server = ServerTextBox.Text;
            builder.UserID = UserIDTextBox.Text;
            builder.Password = PasswordTextBox.Text;
            builder.Port = UInt32.Parse(PortTextBox.Text);
            builder.Database = DataBaseTextBox.Text;
            #endregion

            return builder.ConnectionString;
        }

        private void SqlConnector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SqlListener.ConnectionIsStablish)
            {
                Environment.Exit(0);
            }
        }
    }
}
