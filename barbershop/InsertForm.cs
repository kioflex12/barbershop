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
        private ActiveTables Table { get; set; }

        public InsertForm(ActiveTables table)
        {
            InitializeComponent();
            
            Table = table;

            var columns = SqlListener.GetTableColumns(Tables.EnumConverter.EnumToString(table));
            for (int i = 1; i < columns.Count; i++)
            {
                string columName = columns[i][0];
                InsertDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = columName, HeaderText = columName });
            }
            //foreach (string[] column in SqlListener.GetTableColumns(Tables.EnumConverter.EnumToString(table)))
            //{
            //    if (column[0].Contains("id"))
            //    {
            //        continue;
            //    }
            //    InsertDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = column[0], HeaderText = column[0]});
            //}


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
    }
}
