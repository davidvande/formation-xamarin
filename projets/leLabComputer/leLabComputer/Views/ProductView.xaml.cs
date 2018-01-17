using System;
using System.Collections.Generic;
using leLabComputer.Models;
using Xamarin.Forms;

namespace leLabComputer.Views
{
    public partial class ProductView : ContentPage
    {
        public ProductView(Product product)
        {
            InitializeComponent();

            this.BindingContext = product;
        }
    }
}
