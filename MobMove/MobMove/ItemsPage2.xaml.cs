using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobMove
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
        }

        ObservableCollection<BoxItem> myItems = new ObservableCollection<BoxItem>();


        //***Testing Method. This method to be deleted along with the xaml test button***
        private void TestButton1_Clicked(object sender, EventArgs e)         {
            //develop a collection
            if (myItems.Count == 0)             {                 myItems.Add(new BoxItem { Id = 1, Name = "Brass Knuckles", Quantity = "6", InBox = "Foyer", Photo = "MugShot", Description = "Well used" });                 myItems.Add(new BoxItem { Id = 2, Name = "Tommy Gun", Quantity = "2", InBox = "Lounge", Photo = "MugShot", Description = "Locked and loaded" });                 myItems.Add(new BoxItem { Id = 3, Name = "Teddy Bear", Quantity = "1", InBox = "Master Bedroom", Photo = "MugShot", Description = "Touch it, and you will get cement galoshes!" });             }
            //load it
            itemListView.ItemsSource = myItems;

        }


        //***Trial Method for passing info via menu selection. Not used and to be deleted
        private void MenuItem_Clicked(object sender, EventArgs e)         {             int idOfSelected = (int)((MenuItem)sender).CommandParameter;             var selectedData = myItems.Where(x => x.Id == idOfSelected).ToList<BoxItem>();             string extrainfo = selectedData[0].Description;              DisplayAlert("MoreInfo", extrainfo, "OK");          }

        // Method to pass data from selected listview item to new itemDetail page
        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            /*
            var boxItem = new BoxItem
            {
                Id = 4,
                Name = "Sacks-O-Cash",
                Quantity = "10",
                InBox = "2",
                Photo = "MugShot",
                Description = "Casino Profits"
            };
            */

            var tappedPic = sender as Image;
            var tappedItem = tappedPic.BindingContext as BoxItem;

            var itemDetailPage = new NavigationPage(new ItemDetailPage());
            itemDetailPage.BindingContext = tappedItem;
            await Navigation.PushAsync(itemDetailPage);
            itemListView.SelectedItem = null;
        }

        //Please note - listview slection highlighting disabled via direct alteration to Android style xml

    }
}
