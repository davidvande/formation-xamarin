using Xamarin.Forms;
using apiMvvm.Views;
using apiMvvm.Libs.Interfaces;
using apiMvvm.Libs.Services;

namespace apiMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            RegisterServices();

            MainPage = new apiMvvmPage();
        }

        public void RegisterServices()
        {
            DependencyService.Register<IMovieServices, MovieServices>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
