using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{
    public partial class TabAvion : ContentPage
    {
        public TabAvion()
        {
            InitializeComponent();
            avionImage.Opacity = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            avionImage.TranslationX = -250;
            avionImage.TranslationY = -150;
            avionImage.Rotation = 45;
            avionImage.Scale = 0.7;
            avionImage.Opacity = 0;


            anim();
        }

        private async void anim() {

            uint length = 800;

            await avionImage.FadeTo(1, 100);
            await avionImage.TranslateTo(0, 0, length, Easing.SinOut);
            await avionImage.RotateTo(0, length, Easing.SinOut);
            await avionImage.ScaleTo(1, length, Easing.SinOut);

        }
    }
}
