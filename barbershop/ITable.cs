using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop
{
    public interface ITable
    {
        string UpdateCommand { get; }
        DataGridView JoinDataGrid { get; set; }
    }
}
