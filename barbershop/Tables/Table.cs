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
    }
}
