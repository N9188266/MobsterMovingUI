using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace MobMove
{
    public partial class Boxes : ContentPage
    {
        public Boxes()
        {
            InitializeComponent();
        }

        ObservableCollection<Box> myBoxes = new ObservableCollection<Box>();
        ObservableCollection<BoxItem> itemsInBox = new ObservableCollection<BoxItem>();
        Box currentBox = new Box();


        //***Testing Method. This method to be changed to call an alert and add one box input by user***
        private void AddBoxButton_Clicked(object sender, EventArgs e)
        {
            EnteredName.Text = string.Empty;
            overlay.IsVisible = true;
            EnteredName.Focus();

            //develop a collection
            if (myBoxes.Count == 0)
            {
                myBoxes.Add(new Box { Id = 1, Name = "Master Bedroom", Category = "Bedroom", BoxNumber = 1, ItemQuantity = 3 });
                myBoxes.Add(new Box { Id = 2, Name = "Foyer", Category = "Entry", BoxNumber = 2, ItemQuantity = 7 });
                myBoxes.Add(new Box { Id = 3, Name = "Kitchen", Category = "Kitchen", BoxNumber = 3, ItemQuantity = 0 });
                BoxCountLabel.Text = "1 of 3";
            }
            //load it
            CarouselBoxes.ItemsSource = myBoxes;

        }

        //***Testing Method. This method to be changed to delete the current box if it is empty (and exists)***
        private void DeleteBoxButton_Clicked(object sender, EventArgs e)
        {
            BoysAlert.IsVisible = true;
            BoysMessage.Text = "Sorry Boss, you can't delete a box if it is not there or still has stuff in it.";

        }

        //Method to update page details to correspond to the Current Box on the carousel
        private void UpdateCurrentBox(object sender, EventArgs e)
        {
            int openBox = CarouselBoxes.Position+1;
            itemsInBox.Clear(); //clear list for this box so can add appropriate items

            if (myBoxes.Count > 0)
            {
                BoxCountLabel.Text = openBox + " of " + myBoxes.Count;
                string boxName = myBoxes[CarouselBoxes.Position].Name;


                //Other updates go here, such as updating listview to current box (testing below)
                itemsInBox.Clear();
                if (openBox == 1)
                {
                    itemsInBox.Add(new BoxItem { Id = 1, Name = "Brass Knuckles", Quantity = "6", InBox=boxName, Photo = "MugShot", Description = "Well used" });
                    itemsInBox.Add(new BoxItem { Id = 2, Name = "Hat", Quantity = "1", InBox = boxName, Photo = "MugShot", Description = "Real Fine" });
                    itemsInBox.Add(new BoxItem { Id = 3, Name = "Teddy Bear", Quantity = "1", InBox = boxName, Photo = "MugShot", Description = "Touch it, and you will get cement galoshes!" });
                }
                if (openBox == 2)
                {
                    itemsInBox.Add(new BoxItem { Id = 1, Name = "Tommy Guns", Quantity = "6", InBox = boxName, Photo = "MugShot", Description = "Well used" });
                    itemsInBox.Add(new BoxItem { Id = 1, Name = "Lounge Chair", Quantity = "1", InBox = boxName, Photo = "MugShot", Description = "Soft" });
                    itemsInBox.Add(new BoxItem { Id = 2, Name = "Coffee Table", Quantity = "1", InBox = boxName, Photo = "MugShot", Description = "Small and round" });
                    itemsInBox.Add(new BoxItem { Id = 3, Name = "Painting of the Boss", Quantity = "1", InBox = boxName, Photo = "MugShot", Description = "Touch it, and you will get cement galoshes!" });
                    itemsInBox.Add(new BoxItem { Id = 1, Name = "Trench Coats", Quantity = "3", InBox = boxName, Photo = "MugShot", Description = "Heavy" });
                    itemsInBox.Add(new BoxItem { Id = 1, Name = "Mallet", Quantity = "1", InBox = boxName, Photo = "MugShot", Description = "Well used" });
                    itemsInBox.Add(new BoxItem { Id = 1, Name = "Curtains", Quantity = "2", InBox = boxName, Photo = "MugShot", Description = "Red" });
                }
                itemListView.ItemsSource = itemsInBox;
            }
        }

        // Method to pass data from selected listview item to new itemDetail page
        //This same method is used on the ItemsPage
        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            var tappedPic = sender as Image;
            var tappedItem = tappedPic.BindingContext as BoxItem;

            var itemDetailPage = new NavigationPage(new ItemDetailPage());
            itemDetailPage.BindingContext = tappedItem;
            await Navigation.PushAsync(itemDetailPage);
            itemListView.SelectedItem = null;
        }


        //Uncompleted Method to open a new items-detail page to add a new item similar to above
        private void AddItemButton_Clicked(object sender, EventArgs e)
        {
            
        }

        // ****Buttons for Enter Box Name Overlay follow****

        void OnOKButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = false;
            DisplayAlert("Result", string.Format("You entered {0}", EnteredName.Text), "OK");
        }

        void OnCancelButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = false;
        }

        void OnBoysButtonClicked(object sender, EventArgs args)
        {
            BoysAlert.IsVisible = false;
        }

    }
}
