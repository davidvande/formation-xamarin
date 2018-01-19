using System.Threading.Tasks;
using apiMvvm.Models;

namespace apiMvvm.Libs.Interfaces
{
    public interface IMovieServices
    {
        Task<MovieResult> GetListMovies(string search);
    }
}