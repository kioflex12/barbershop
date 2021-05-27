using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barbershop.Tables
{ 
    public static class EnumConverter
    {
        public static string EnumToString(ActiveTables table) => Enum.GetName(typeof(ActiveTables), (int)table);
    }
    public enum ActiveTables
    {
        clients,
        masters,
        services,
        orders,
       

    }
}
