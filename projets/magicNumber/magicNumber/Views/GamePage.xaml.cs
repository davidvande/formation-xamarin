using System;
using System.Collections.Generic;
using magicNumber.Configuration;
using Xamarin.Forms;

namespace magicNumber.Views
{
    public partial class GamePage : ContentPage
    {
        private int result;

        private readonly int BorneMin;
        private readonly int BorneMax;

        public GamePage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BorneMin = Constants.BorneMin;
            BorneMax = Constants.BorneMax;

            lbIntro.Text = string.Format("Devinez le nombre entre {0} et {1}", BorneMin, BorneMax);

            Random r = new Random();
            result = r.Next(BorneMin, BorneMax);

            numberInput.Focus();
            numberInput.Focused += (sender, e) => ((Entry)sender).Text = string.Empty;

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
                    if (input > BorneMax)
                    {
                        await DisplayAlert("Erreur de saisie", string.Format("La saisie doit être inférieure à {0}", BorneMax), "OK");
                    }
                    else if (input < BorneMin)
                    {
                        await DisplayAlert("Erreur de saisie", string.Format("La saisie doit être supérieure à {0}", BorneMin), "OK");
                    } 
                    else if (result > input) 
                    {
                        await DisplayAlert("Erreur de saisie", string.Format("Le nombre magique est supérieur à {0}", input), "OK");
                    }
                    else
                    {
                        await DisplayAlert("Erreur de saisie", string.Format("Le nombre magique est inférieur à {0}", input), "OK");
                    }
                }

            } else
            {
                await DisplayAlert("Erreur de saisie", "La donnée saisie n'est pas un nombre entier", "Réessayer");
            }

            numberInput.Focus();
        }
    }
}
