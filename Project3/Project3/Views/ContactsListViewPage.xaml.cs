using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.ViewModels;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsListViewPage : ContentPage
    {
        public ContactsListViewPage()
        {
            InitializeComponent();
        }

        private void AddContactBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddAContactPage()); 
        }
        protected override void OnAppearing()
        {
            listView.ItemsSource = ContactsViewModel.Contacts; 
        }
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                Navigation.PushModalAsync(new EditDeleteContactViewPage()); 
            }
        }
    }

   
}