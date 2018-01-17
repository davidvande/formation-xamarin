using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace magicNumber.Views
{
    public partial class GamePage : ContentPage
    {
        private int result;

        public GamePage()
        {
            InitializeComponent();

            Random r = new Random();
            result = r.Next(0, 10);
        }

        async protected void btDeviner_Clicked(Object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(numberInput.Text, out input))
            {
                if (result == input)
                { 
                    var winPage = new WinPage(result);
                    await Navigation.PushAsync(winPage);
                }
                else
                { 
                    if (result > input)
                        await DisplayAlert("Erreur de saisie", string.Format("Le nombre magique est supérieur à {0}", input), "OK");
                    else
                        await DisplayAlert("Erreur de saisie", string.Format("Le nombre magique est inférieur à {0}", input), "OK");
                }

            } else
            {
                await DisplayAlert("Erreur de saisie", "La donnée saisie n'est pas un nombre", "OK");
            }
        }
    }
}
