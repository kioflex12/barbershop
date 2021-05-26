using barbershop.Tables;
using barbershop.Tables.DataSource;
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
            SqlListener.InitConnection();

            DataSource.SetDataAdditictions(
                TableDataSource.tablesData = new Dictionary<ActiveTables, TableDataSource.TableData>()
                {
                    { ActiveTables.Clients ,new TableDataSource.TableData(new Clients(ClientsDataGrid)) },
                    { ActiveTables.Masters ,new TableDataSource.TableData(new Masters(MastersDataGrid)) }
                    //new TableDataSource.TableData(Table.Masters, new Masters(Clients)),
                    //new TableDataSource.TableData(Table.Orders, new Orders(Clients)),
                    //newа TableDataSource.TableData(Table.Services, new Sevices(Clients)),
                });
            


        }
        private void InsertButoon_Click(object sender, EventArgs e)
        {
            var currentTable = (ActiveTables)tabControl.SelectedIndex;
            InsertForm insertForm = new InsertForm(DataSource.tables[currentTable].TableSource.JoinDataGrid, currentTable );
            insertForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in ClientsDataGrid.SelectedCells)
            {
                var rowIndex = cell.RowIndex;
                SqlListener.ExecuteQuery(SqlListener.GetDeleteString((ActiveTables)tabControl.SelectedIndex, ClientsDataGrid.Rows[rowIndex].Cells[0].Value.ToString()));
            }
            DataSource.UpdateDataGridViews();
        }

        
    }
}
