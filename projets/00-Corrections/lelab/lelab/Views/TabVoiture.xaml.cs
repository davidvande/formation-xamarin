using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{
    public partial class TabVoiture : ContentPage
    {
        public TabVoiture()
        {
            InitializeComponent();
            voitureImage.Opacity = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            voitureImage.TranslationX = 0;
            voitureImage.Opacity = 0;
            voitureImage.FadeTo(1, 1000);
            voitureImage.TranslateTo(50,0,1000, Easing.CubicOut);

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            voitureImage.Opacity = 0;
            voitureImage.TranslationX = 0;
        }
    }
}
