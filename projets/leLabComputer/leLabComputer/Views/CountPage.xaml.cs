using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace leLabComputer.Views
{
    public partial class CountPage : ContentPage
    {
        private int compteur;
        
        public CountPage()
        {
            InitializeComponent();

            this.Title = "Le compteur";
        }

        void btCompter_clicked(object sender, EventArgs e)
        {
            Console.WriteLine(string.Format("Avant : {0}", compteur));
            
            lbCompteur.Text = (++compteur).ToString();

            Console.WriteLine(string.Format("Après : {0}", compteur));

        }
    }
}
