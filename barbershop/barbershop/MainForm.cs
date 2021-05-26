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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter1.Fill(this.barbershopDataSet1.Clients);
            DataSource.InitConnection();
            DataSource.SetDataAdditictions(new List<DataGridView> { Clients });
            


        }

        private void InsertButoon_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm(Clients);
            insertForm.ShowDialog();
        }
    }
}
