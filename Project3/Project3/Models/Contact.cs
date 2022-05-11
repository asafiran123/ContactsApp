using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Project3.ViewModels;
using SQLite; 

namespace Project3.Models
{
    [Table ("ContactTable")] 
    public class Contact
    {
        [PrimaryKey,AutoIncrement]

        public int ID { get; set; }
        public string contactNameFirst { get; set; }

        public string contactNameLast { get; set; }

        public string contactType { get; set; }  

       public string FullName => contactNameFirst + " " +  contactNameLast; 

        public Contact ()
        {

        }

        public Contact (string contactNameFirst, string contactNameLast, string contactType, int id)
        {
           this.contactNameFirst = contactNameFirst;
           this.contactNameLast = contactNameLast;
            this.contactType = contactType;
            this.ID = id; 
          
           
        }
    }
}
