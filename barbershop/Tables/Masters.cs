using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop.Tables
{
    internal class Masters : Table
    {
        public Masters(DataGridView dataGrid) : base(dataGrid)
        {
        }

        public override string UpdateCommand => "select * from Masters";


    }
}
