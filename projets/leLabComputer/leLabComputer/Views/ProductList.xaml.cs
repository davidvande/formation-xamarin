using System;
using System.Collections.Generic;
using leLabComputer.Models;
using Xamarin.Forms;

namespace leLabComputer.Views
{
    public partial class ProductList : ContentPage
    {
        private List<Product> _products;
        
        public ProductList()
        {
            InitializeComponent();

            this.Title = "Les produits";

            _products = new List<Product>();

            for (var i = 0; i < 100; i++)
            {
                _products.Add(
                    new Product() {
                        Name = "Chocolatine",
                        Description = "La meilleure chocolatine du monde !!!",
                        Price = 0.40f,
                        Visual = "lab_voiture.png"
                    }
                );
                _products.Add(
                    new Product()
                    {
                        Name = "Petit pain",
                        Description = "L'petit pain pur beurre qui guile juste c'qui faut.",
                        Price = 0.92f,
                        Visual = "lab_avion.png"
                    }
                );
                _products.Add(
                    new Product()
                    {
                        Name = "Croissant",
                        Description = "L'croissant pur beurre qui guile juste c'qui faut.",
                        Price = 0.80f,
                        Visual = "lab_avion.png"
                    }
                );
                _products.Add(
                    new Product()
                    {
                        Name = "Coucke suisse",
                    Description = "L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!! L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!L'truc qui guile y'a pas plus, mais mmmmmmm c'est bon !!!",
                        Price = 2.00f,
                        Visual = "lab_avion.png"
                    }
                );
            }

            lProducts.ItemsSource = _products;

        }

        async void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }

            Product p = (Product)e.SelectedItem;

            await DisplayAlert(p.Name, string.Format("{0} - {1:C}", p.Description, p.Price), "OK");

            var productView = new ProductView((Product)e.SelectedItem);
            await Navigation.PushAsync(productView);
        }
    }
}
