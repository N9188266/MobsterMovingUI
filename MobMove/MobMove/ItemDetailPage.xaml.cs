using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobMove
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
        }

        //Method to navigate back, but automatically seems to already have a navigate back arrow
        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        //Uncompleted method to deal with pen icon click. Probably need to be async.
        public void OnPenClicked(object sender, EventArgs e)
        {

        }

        //Uncompleted method to deal with photo being clicked (to take new photo)
        public void OnPictureClicked(object sender, EventArgs e)
        {

        }

    }
}
