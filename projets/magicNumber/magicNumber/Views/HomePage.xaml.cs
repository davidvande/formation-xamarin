using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace magicNumber.Views
{
    public partial class HomePage : ContentPage
    {
        Animation animBig;
        Animation animSmall;
        
        public HomePage()
        {
            InitializeComponent();

            animBig = new Animation(v => btJouer.Scale = v, 1, 1.1);
            animSmall = new Animation(v => btJouer.Scale = v, 1.1, 1);

            bigger();
        }

        private void bigger()
        {
            animBig.Commit(this, "Bouton jouer", 16, 1000, null, (v, c) => smaller(), () => false);
        }

        private void smaller()
        {
            animSmall.Commit(this, "Bouton jouer", 16, 1000, null, (v, c) => bigger(), () => false);
        }

        async protected void btJouer_Clicked(Object sender, EventArgs e)
        {
            var gamePage = new GamePage();
            await Navigation.PushAsync(gamePage);
        }
    }
}
