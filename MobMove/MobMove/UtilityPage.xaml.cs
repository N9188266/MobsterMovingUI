using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobMove
{
    public partial class UtilityPage : ContentPage
    {
        public UtilityPage()
        {
            InitializeComponent();
        }

        // Method to open print page
        async void GoPrintPage(object sender, EventArgs e)
        {
            var newPrintPage = new NavigationPage(new PrintPage());
            await Navigation.PushAsync(newPrintPage);
        }

        private void NotImplimented_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Not Implimented", "Sorry, this function to be added in when greenlight", "OK");
        }

    }
}
