using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using barbershop.Tables;
namespace barbershop.Tables.DataSource
{
    public static class TableDataSource
    {
       
        
        public static Dictionary<ActiveTables, TableData> tablesData;

        [Serializable]
        public class TableData
        {
            public TableData(Table tableSource)
            {
                this.TableSource = tableSource;
            }
            public Table TableSource;
        }
    }
}
