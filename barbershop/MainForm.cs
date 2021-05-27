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
        private ActiveTables currentTable;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlListener.InitConnection();

            DataSource.SetDataAdditictions(
                TableDataSource.tablesData = new Dictionary<ActiveTables, TableDataSource.TableData>()
                {
                    { ActiveTables.clients,  new TableDataSource.TableData(new Clients(ClientsDataGrid))   },
                    { ActiveTables.masters,  new TableDataSource.TableData(new Masters(MastersDataGrid))   },
                    { ActiveTables.services, new TableDataSource.TableData(new Services(ServicesDataGrid)) },
                    { ActiveTables.orders,   new TableDataSource.TableData(new Orders(OrdersDataGridView)) },
                    
                });
            


        }

        private void TabControl_SelectionChanged(object sender, TabControlEventArgs e)
        {
            currentTable = (ActiveTables)tabControl.SelectedIndex;
        }
        private void InsertButon_Click(object sender, EventArgs e)
        {
           
            InsertForm insertForm = new InsertForm(currentTable);
            insertForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in DataSource.tables[currentTable].TableSource.JoinDataGrid.SelectedCells)
            {
                var rowIndex = cell.RowIndex;
                SqlListener.ExecuteQuery(DataSource.tables[currentTable].TableSource.GetDeleteString(
                    DataSource.tables[currentTable].TableSource.JoinDataGrid.Rows[rowIndex].Cells[0].Value.ToString(), currentTable));
            }
            DataSource.UpdateDataGridViews();
        }

       
    }
}
