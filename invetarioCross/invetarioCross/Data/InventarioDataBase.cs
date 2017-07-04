using invetarioCross.Models;
using invetarioCross.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace invetarioCross.Data
{
   public partial class InventarioDataBase
    {
        static readonly SQLiteConnection database = DependencyService.Get<IDatabaseConnection>().DbConnection();

        public static List<LECTURA_PRODUCTO> GetItemsNotDoneAsync(string numero)
        {

            return database.Query<LECTURA_PRODUCTO>("SELECT * FROM [LECTURA_PRODUCTO] WHERE [CODIGO_IDENTIFICADOR] = '" + numero + "'");
            
        }
    }
}
