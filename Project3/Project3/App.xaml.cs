using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Project3.Views; 

namespace Project3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage ( new ContactsListViewPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
