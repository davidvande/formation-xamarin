using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace magicNumber.Views.Fragments
{
    public partial class HeaderNavigation : ContentView
    {
        public HeaderNavigation()
        {
            InitializeComponent();

            Animate();
        }

        private void Animate()
        {
            star1.RotateTo(360, 1000);
            star2.RotateTo(360, 1000);
            star3.RotateTo(360, 1000);

            this.Animate();
        }
    }
}
