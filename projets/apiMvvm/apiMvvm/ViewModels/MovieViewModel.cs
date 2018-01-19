using System;
using System.Collections.Generic;
using apiMvvm.Models;
using System.Windows.Input;
using Xamarin.Forms;
using apiMvvm.Libs.Interfaces;

namespace apiMvvm.ViewModels
{
    public class MovieViewModel
    {
        public MovieViewModel()
        {
        }

        public string search
        {
            get;
            set;
        }

        public List<Movie> MovieResult
        {
            get;
            set;
        }

        public ICommand RechercherCommand { get { return new Command(RechercherAction); } }

        private async void RechercherAction()
        {
            IMovieServices service = DependencyService.Get<IMovieServices>();
            MovieResult movies = await service.GetListMovies(this.search);

            MovieResult = movies.Search;

        }
    }
}
