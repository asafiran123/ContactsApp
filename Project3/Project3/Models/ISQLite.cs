using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Project3.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection(); 
    }

}
