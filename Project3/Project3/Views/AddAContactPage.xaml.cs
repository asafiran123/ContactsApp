using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAContactPage : ContentPage
    {
        public AddAContactPage()
        {
            InitializeComponent();
        }

        private void ReturnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(IsEnabled); 
        }

        private void SaveContactButton_Clicked(object sender, EventArgs e)
        {
            
        
        }
    }
}