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
using System.Resources;

namespace barbershop
{
    public partial class InsertForm : Form
    {
        private ActiveTables Table { get; set; }

        public InsertForm(ActiveTables table)
        {
            InitializeComponent();
            Table = table;
            InsertDataGridView.Columns.AddRange(TableDataSource.tablesData[table].TableSource.GetColumnForDataGridView(table).ToArray());
        }
       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckFildComplete())
            {

                for (int i = 0; i < InsertDataGridView.Rows.Count - 1; i++)
                {
                    var insertString = DataSource.tables[Table].TableSource.GetInsertString(InsertDataGridView.Rows[i], Table);
                    if (insertString == null)
                    {
                        errorProvider.SetError(InsertDataGridView, "проверьте правильность введённых данных");
                    }
                    else
                    {
                        SqlListener.ExecuteQuery(insertString);
                        
                        InsertDataGridView.Rows.RemoveAt(i);
                        i = -1;

                    }
                }
                DataSource.UpdateDataGridViews();
                this.Close();
            }
            else
                errorProvider.SetError(InsertDataGridView, "заполните все ячейки");
        }

        private bool CheckFildComplete()
        {
            for (int i = 0; i < InsertDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < InsertDataGridView.Columns.Count; j++)
                {
                    if (string.IsNullOrEmpty(InsertDataGridView.Rows[i].Cells[j].Value?.ToString()))
                    {

                        return false;
                    }
                }
            }
            return true;
        }

        private void InsertDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (InsertDataGridView.Rows.Count != 0)
            {
                var curentCell = InsertDataGridView.Rows?[e.RowIndex].Cells[e.ColumnIndex];

                if (curentCell.GetType().Name.Equals(typeof(DataGridViewComboBoxCell).Name))
                {
                    if (!Int32.TryParse(curentCell.Value.ToString(), out _))
                    {
                        string columnName = InsertDataGridView.Columns[e.ColumnIndex].Name;
                        var query = $"select {columnName} from {columnName.Split('_')[1]}s where full_name = '{curentCell.Value}'";
                        curentCell.Tag = SqlListener.GetQueryResult(query)[0][0];

                    }

                }
            }
        }
    }
}
