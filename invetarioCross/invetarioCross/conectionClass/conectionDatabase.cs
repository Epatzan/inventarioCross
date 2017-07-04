using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
//using Windows.Storage;



namespace invetarioCross.conectionClass
{
    public   class conectionDatabase
    {
       public  string databasePath {
            get {
                var dbName = "CustomersDb.db3";
                #if __IOS__
                                string folder = Enviroment.GetFolderPath (Enviroment.SpecialFolder.Personal);
                                folder = Path.Combine (folder,"..","Library");
                                var databasePath = Path.Combine(folder, dbName);
                                var complete = new SQLiteConnection(databasePath, SQLiteOpenFlags.ReadWrite);

                #else
                #if __WINDOWS_UWP__

                                //      var databasePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
                                //var complete = new SQLiteAsyncConnection(databasePath, SQLiteOpenFlags.ReadWrite);
                                var complete = new SQLiteConnection(databasePath,SQLiteOpenFlags.ReadWrite);

                #else
                                string documenthPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                                var databasePath = Path.Combine(documenthPath, dbName);
                                var complete = new SQLiteConnection(databasePath, SQLiteOpenFlags.ReadWrite);
#endif
#endif
                return complete.ToString();
                //string documenthPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); 
                
            }
        }
        
    }
}
