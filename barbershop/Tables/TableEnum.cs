using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barbershop.Tables
{ 
    public static class EnumConverter
    {
        /// <summary>
        /// Преобразует перечисление в строку
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static string EnumToString(ActiveTables table) => Enum.GetName(typeof(ActiveTables), (int)table);
    }
    /// <summary>
    /// Перечисление таблиц
    /// </summary>
    public enum ActiveTables
    {
        clients,
        masters,
        services,
        orders,
       

    }
}
