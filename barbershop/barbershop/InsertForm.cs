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

        public InsertForm(DataGridView dataGridView)
        {
            InitializeComponent();
            _currentDataGridView = dataGridView;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                InsertDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = column.Name, HeaderText = column.HeaderText });
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CheckFildComplete())
            {

                for (int i = 0; i < InsertDataGridView.Rows.Count - 1; i++)
                {
                    DataSource.Insert(_currentDataGridView, InsertDataGridView.Rows[i]);
                }


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
