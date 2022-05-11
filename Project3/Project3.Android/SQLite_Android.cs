using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms; 
using Project3.Models;
using Project3.Droid; 

[assembly: Dependency(typeof(SQLite_Android))]

namespace Project3.Droid
{
    public class SQLite_Android : ISQLite
    {

        public SQLite_Android()
        {

        }
        #region ISQLite implementation
        public SQLiteConnection GetConnection()
        {
            var fileName = "ContactsDatabase.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
    #endregion
 } 
