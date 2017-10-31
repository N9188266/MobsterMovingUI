using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;

namespace MobMove
{
    public partial class PrintPage : ContentPage
    {
        public PrintPage()
        {
            InitializeComponent();
        }

        ObservableCollection<Box> myBoxes = new ObservableCollection<Box>();
        bool list = true;
        bool boxNums = true;
        bool rooms = false;
        bool qRCode = false;

        //Method to update page details to correspond to the Current Box on the carousel
        private void UpdateCurrentBox(object sender, EventArgs e)
        {
            int openBox = CarouselBoxes.Position + 1;

            if (myBoxes.Count > 0)
            {
                BoxCountLabel.Text = openBox + " of " + myBoxes.Count;
            }
        }


        private void ItemList_Clicked(object sender, EventArgs e)
        {
            ListTick.IsVisible = !list;
            list = !list; 
        }

        private void BoxNumbers_Clicked(object sender, EventArgs e)
        {
            BoxesTick.IsVisible = !boxNums;
            boxNums = !boxNums;
        }

        private void RoomType_Clicked(object sender, EventArgs e)
        {
            RoomTick.IsVisible = !rooms;
            rooms = !rooms;
        }

        private void QRCode_Clicked(object sender, EventArgs e)
        {
            QRTick.IsVisible = !qRCode;
            qRCode = !qRCode;
        }

        private void UpdateAllButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void PrintCurrentButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void PrintAllButton_Clicked(object sender, EventArgs e)
        {
            
        }

    }
}
