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
        private ActiveTables _currentTable;
        private DataGridView _currentDataGrid;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new SqlConnector().ShowDialog();

            DataSource.SetupTablesData(
                TableDataSource.tablesData = new Dictionary<ActiveTables, TableDataSource.TableData>()
                {
                    { ActiveTables.clients,  new TableDataSource.TableData(new Clients(ClientsDataGrid))   },
                    { ActiveTables.masters,  new TableDataSource.TableData(new Masters(MastersDataGrid))   },
                    { ActiveTables.services, new TableDataSource.TableData(new Services(ServicesDataGrid)) },
                    { ActiveTables.orders,   new TableDataSource.TableData(new Orders(OrdersDataGrid))     },
                    
                });

            SetNewTable();

        }
        
        /// <summary>
        /// Устанавливает новую таблицу
        /// </summary>
        private void SetNewTable()
        {
            _currentTable = (ActiveTables)TabControl.SelectedIndex;
            _currentDataGrid = DataSource.tables[_currentTable].TableSource.JoinDataGrid;
        }

        private void TabControl_SelectionChanged(object sender, TabControlEventArgs e)
        {
            SetNewTable();
        }

        private void InsertButon_Click(object sender, EventArgs e)
        {
           
            InsertForm insertForm = new InsertForm(_currentTable);
            insertForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in _currentDataGrid.SelectedCells)
            {
                var rowIndex = cell.RowIndex;
                SqlListener.ExecuteQuery(DataSource.tables[_currentTable].TableSource.GetDeleteString(
                    _currentDataGrid.Rows[rowIndex].Cells[0].Value.ToString(), _currentTable));
            }
            DataSource.UpdateDataGridViews();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            ExcelSaver.SaveToCSV(_currentDataGrid);
        }

      
    }
}
