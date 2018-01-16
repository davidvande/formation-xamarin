using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace leLabComputer.Views
{
    public partial class CarPage : ContentPage
    {
        private readonly double posXInit;
        private readonly double posYInit;
        
        public CarPage()
        {   
            InitializeComponent();

            this.Title = "Voiture";

            posXInit = this.imgVoiture.X;
            posYInit = this.imgVoiture.Y;

            initPlaneState();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            animate();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            initPlaneState();
        }

        private void animate()
        {
            // On sort la voiture
            this.imgVoiture.FadeTo(1, 1500);
            this.imgVoiture.TranslateTo(posXInit, posYInit, 3000, Easing.CubicOut);
        }

        private void initPlaneState()
        {
            // On sort la voiture
            this.imgVoiture.FadeTo(0, 0);
            this.imgVoiture.TranslateTo(-500, posYInit, 0);
        }
    }
}
