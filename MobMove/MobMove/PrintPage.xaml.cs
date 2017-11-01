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


        //***TickToggles***

        private void ItemList_Clicked(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            if (list)
            {
                imageSender.Source = "IconTickNo";
            }
            else
            {
                imageSender.Source = "IconTickYes";
            }
            list = !list; 
        }

        private void BoxNumbers_Clicked(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            if (boxNums)
            {
                imageSender.Source = "IconTickNo";
            }
            else
            {
                imageSender.Source = "IconTickYes";
            }
            boxNums = !boxNums;
        }

        private void RoomType_Clicked(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            if (rooms)
            {
                imageSender.Source = "IconTickNo";
            }
            else
            {
                imageSender.Source = "IconTickYes";
            }
            rooms = !rooms;
        }

        private void QRCode_Clicked(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;

            if (qRCode)
            {
                imageSender.Source = "IconTickNo";
            }
            else
            {
                imageSender.Source = "IconTickYes";
            }
            qRCode = !qRCode;
        }


        //***Print Buttons***

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
