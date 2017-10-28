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


        //***Testing Method. This method to be changed to call an alert and add one box input by user***
        private void AddBoxButton_Clicked(object sender, EventArgs e)
        {
            //develop a collection
            if (myBoxes.Count == 0)
            {
                myBoxes.Add(new Box { Id = 1, Name = "Master Bedroom", Category = "Bedroom", Number = 1 });
                myBoxes.Add(new Box { Id = 2, Name = "Foyer", Category = "Entry", Number = 2 });
                myBoxes.Add(new Box { Id = 3, Name = "Kitchen", Category = "Kitchen", Number = 3 });
            }
            //load it
            CarouselBoxes.ItemsSource = myBoxes;

        }

        //***Testing Method. This method to be changed to delete the current box if it is empty (and exists)***
        private void DeleteBoxButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Rub Out Dat Box", "Sorry Boss, you can't delete a box if it is not there or still has stuff in it.", "OK");

        }

        //Uncompleted Method to open a new items-detail page to add a new item
        private void AddItemButton_Clicked(object sender, EventArgs e)
        {
            
        }


    }
}
