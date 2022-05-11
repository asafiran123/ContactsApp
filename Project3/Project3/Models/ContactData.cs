using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;
using SQLite; 

namespace Project3.Models
{
    public class ContactData
    {
        private SQLiteConnection _connection;

        //public string Contact { get; private set; }


        public ContactData()
        {
            _connection = DependencyService.Get<ISQLite>().GetConnection(); 
            _connection.CreateTable<Contact>();
        }

        public int Count()
        {
            return _connection.Table<Contact>().Count();
        }

        public IList<Contact> GetContacts()
        {
            return _connection.Query<Contact>("SELECT * FROM ContactTable ORDER BY contactNameLast"); 

        }
        public void DeleteContact(int ID)
        {
            _connection.Delete<Contact>(ID);
        }
        public void AddContact(string firstname, string lastname, string contacttype)
        {
            var newContact = new Contact()
            {
                contactNameFirst = firstname,
                contactNameLast = lastname,
                contactType = contacttype,
            };
            _connection.Insert(newContact);



        }

        public void UpdateContact (string firstname, string lastname, string contacttype, int ID)
        {
            _connection.Execute("UPDATE ContactTable SET contactNameFirst =?,contactNameLast=?, contactType=?, WHERE ID=?", firstname, lastname, contacttype, ID); 
        }

        
    }

   
    
       
    }


