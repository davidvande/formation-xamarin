using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace magicNumber.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async protected void btJouer_Clicked(Object sender, EventArgs e)
        {
            var gamePage = new GamePage();
            await Navigation.PushAsync(gamePage);
        }
    }
}
