using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invetarioCross.Services
{
   public  interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();

        //string GetLocalFilePath(string filename);
    }
}
