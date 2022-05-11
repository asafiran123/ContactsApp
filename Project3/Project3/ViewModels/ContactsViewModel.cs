using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Project3.Models;
using System.IO; 
using Xamarin.Forms;


namespace Project3.ViewModels
{
    public class ContactsViewModel : ViewModelBase
    {
        private static ContactData contactData = new ContactData();
        private static Contact selectedContact = null;
        private static Contact saveContact = new Contact();
        private Contact contact = new Contact();
        
       
        public Contact Contact
        {
            get => contact;

            set
            {

                contact = value;
                OnPropertyChanged();
            }


        }
        public Contact SelectedContact

        {
            get => selectedContact;
            set
            {
                if (value != null)
                {
                    selectedContact = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand AddContactCommand
        {
            get; private set;
        }
        public ICommand DeleteCommand { get; private set; }

        public ICommand UpdateCommand { get; private set; }

        public ContactsViewModel()
        {




            AddContactCommand = new Command(execute: () =>
            {
                contactData.AddContact(Contact.contactNameFirst, Contact.contactNameLast, Contact.contactType);
                Contact.ID = contactData.Count(); 

            });

            DeleteCommand = new Command(execute: () =>
            {
                
                
                    contactData.DeleteContact(SelectedContact.ID); 

                
            });

            UpdateCommand = new Command(execute: () =>
            {
                contactData.UpdateContact(SelectedContact.contactNameFirst, SelectedContact.contactNameLast, SelectedContact.contactType, SelectedContact.ID); 
            }); 



        }




        public static IList<Contact> Contacts => contactData.GetContacts();







    }
} 