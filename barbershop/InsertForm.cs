using barbershop.Tables;
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
    public partial class InsertForm : Form
    {
        private DataGridView _currentDataGridView;
        private ActiveTables Table { get; set; }

        public InsertForm(DataGridView dataGridView, ActiveTables table)
        {
            InitializeComponent();
            _currentDataGridView = dataGridView;
            Table = table;


            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Name.Contains("id"))
                {
                    continue;
                }
                InsertDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = column.Name, HeaderText = column.HeaderText });
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CheckFildComplete())
            {

                for (int i = 0; i < InsertDataGridView.Rows.Count - 1; i++)
                {
                    var insertString = SqlListener.GetInsertString(InsertDataGridView.Rows[i],Table);
                    if (insertString == null)
                    {
                        errorProvider.SetError(InsertDataGridView, "проверьте правильность введённых данных");
                        return;
                    }
                    else
                    {
                        DataSource.Insert(insertString);
                        
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
                for (int j = 0; j < InsertDataGridView.Columns.Count - 1; j++)
                {
                    if (string.IsNullOrEmpty(InsertDataGridView.Rows[i].Cells[j].Value?.ToString()))
                    {

                        return false;
                    }
                }
            }
            return true;
        }
    }
}
