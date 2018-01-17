using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace magicNumber.Views
{
    public partial class WinPage : ContentPage
    {
        public WinPage(int result)
        {
            InitializeComponent();

            resultLabel.Text = string.Format("Le nombre magique est : {0}", result);
        }

        async protected void btRetour_Clicked(Object sender, EventArgs e)
        {
            var gamePage = new GamePage();
            await Navigation.PushAsync(gamePage);
        }
    }
}
