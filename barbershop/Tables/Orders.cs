using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbershop.Tables
{
    class Orders : Table, ITable
    {
        public Orders(DataGridView dataGrid) : base(dataGrid)
        {
        }

        public string UpdateCommand => @"SELECT orders.id_order, services.name, services.price, clients.full_name, orders.date_of_service, masters.full_name AS master
                                         FROM orders 
                                         INNER JOIN services 
                                         ON 
                                         orders.id_service = services.id_service 
                                         INNER JOIN masters 
                                         ON 
                                         orders.id_master = masters.id_master 
                                         INNER JOIN clients 
                                         ON 
                                         orders.id_client = clients.id_client";
    }
}
