using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop.Tables
{
    internal class Masters : Table, ITable
    {
        public Masters(DataGridView dataGrid) : base(dataGrid)
        {
        }

        public string UpdateCommand => "select * from Masters";


        public void Delete(string value)
        {
            throw new NotImplementedException();
        }
    }
}
