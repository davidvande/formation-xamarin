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
    
        async void btVehicules_Clicked(Object sender, EventArgs e)
        {
            var vehiculesTabPage = new VehiculesTabPage();
            await Navigation.PushAsync(vehiculesTabPage);
        }

        async void btProducts_Clicked(Object sender, EventArgs e)
        {
            var productList = new ProductList();
            await Navigation.PushAsync(productList);
        }
    }
}
