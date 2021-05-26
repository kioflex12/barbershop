using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop.Tables
{
    class Services : Table, ITable
    {
        public Services(DataGridView dataGrid) : base(dataGrid)
        {
        }
        public string UpdateCommand => "select * from Services";
    }
}
