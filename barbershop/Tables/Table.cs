using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop.Tables
{
    public class Table
    {
        public DataGridView JoinDataGrid { get; set; }

        public Table(DataGridView dataGrid)
        {
            JoinDataGrid = dataGrid;
        }

        public virtual List<DataGridViewColumn> GetColumnForDataGridView(ActiveTables table)
        {
            List<DataGridViewColumn> dataGridViewcolumns = new List<DataGridViewColumn>();
            var columns = SqlListener.GetTableColumns(Tables.EnumConverter.EnumToString(table));
            for (int i = 1; i < columns.Count; i++)
            {
                string columName = columns[i][0];
                dataGridViewcolumns.Add(new DataGridViewTextBoxColumn() { Name = columName, HeaderText = columName });
            }
            return dataGridViewcolumns;
        }
       
    }
}
