using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop.Tables
{
    class Clients : Table, ITable
    {
        public Clients(DataGridView dataGrid) : base(dataGrid)
        {
        }
       
        public string UpdateCommand => "select * from Clients";


        

        
    }
}
