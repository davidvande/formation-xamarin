using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        void CounterButtonClicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new CountPage());
        }

        void TabsButtonClicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }

        void ListButtonClicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ListPage());
        }
    }
}
