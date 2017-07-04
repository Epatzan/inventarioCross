using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

using System.IO;



using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using invetarioCross.Services;
using invetarioCross.conectionClass;
using invetarioCross.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_Android))]


namespace invetarioCross.Droid
{
    public  class DatabaseConnection_Android : IDatabaseConnection
    {
        conectionDatabase nuevo = new conectionDatabase();

        public SQLiteConnection DbConnection()
        {
            return new SQLiteConnection(nuevo.databasePath);
        }

        /* public string GetLocalFilePath(string filename)
         {
             return nuevo.databasePath;
         }*/
    }
}