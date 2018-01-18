using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace magicNumber.Views
{
    public partial class WinPage : ContentPage
    {
        Animation animBig;
        Animation animSmall;
        
        public WinPage(int result)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            resultLabel.Text = string.Format("Le nombre magique est : {0}", result);

            animBig = new Animation(v => slContent.Scale = v, 1, 1.1);
            animSmall = new Animation(v => slContent.Scale = v, 1.1, 1);

            bigger();

            GoBackHome();
        }

        private void bigger()
        {
            animBig.Commit(this, "Bouton jouer", 16, 1000, null, (v, c) => smaller(), () => false);
        }

        private void smaller()
        {
            animSmall.Commit(this, "Bouton jouer", 16, 1000, null, (v, c) => bigger(), () => false);
        }

        async private void GoBackHome()
        {
            await Task.Delay(5000);
            await Navigation.PopToRootAsync();
        }
    }
}
