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
    public partial class EditDeleteContactViewPage : ContentPage
    {
      
        public EditDeleteContactViewPage()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void CancelEditBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void SaveEditBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}