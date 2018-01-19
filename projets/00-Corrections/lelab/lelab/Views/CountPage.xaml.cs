using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{
    public partial class CountPage : ContentPage
    {
        int count = 0;

        public CountPage()
        {
            InitializeComponent();
        }

        void CountButtonClick(object sender, System.EventArgs e)
        {
            count++;

            countLabel.Text = count.ToString();

            //Console.WriteLine("Bouton cliqué !");
        }
    }
}
