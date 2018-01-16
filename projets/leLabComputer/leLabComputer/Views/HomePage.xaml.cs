using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace leLabComputer.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            this.Title = "Sommaire";
        }

        async void btCompteur_Clicked(Object sender, EventArgs e)
        {
            var countPage = new CountPage();
            await Navigation.PushAsync(countPage);
        }
    }
}
