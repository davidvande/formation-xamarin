using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace leLabComputer.Views
{
    public partial class PlanePage : ContentPage
    {
        private readonly double posXInit;
        private readonly double posYInit;
        
        public PlanePage()
        {
            InitializeComponent();

            this.Title = "Avion";

            posXInit = this.imgAvion.X;
            posYInit = this.imgAvion.Y;

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
            // On sort l'avion
            this.imgAvion.RotateTo(-15, 1500);
            this.imgAvion.FadeTo(100, 1500);
            this.imgAvion.TranslateTo(posXInit, posYInit, 1500, Easing.SinOut);
        }

        private void initPlaneState()
        {

            // On sort l'avion
            this.imgAvion.RotateTo(0, 0);
            this.imgAvion.FadeTo(0, 0);
            this.imgAvion.TranslateTo(-500, -200, 0);
        }
    }
}
