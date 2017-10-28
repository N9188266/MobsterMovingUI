using System;

using Xamarin.Forms;

namespace MobMove
{
    public class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

