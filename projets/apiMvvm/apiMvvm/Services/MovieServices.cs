using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using apiMvvm.Libs.Interfaces;
using apiMvvm.Models;
using Newtonsoft.Json;

namespace apiMvvm.Libs.Services
{
    public class MovieServices : IMovieServices
    {
        public MovieServices()
        {
        }

        public async Task<MovieResult> GetListMovies(string search)
        {
            string result = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync(string.Format("?s={0}&apikey=56d7b021", search));
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }

            }
            
            return !string.IsNullOrEmpty(result) ? JsonConvert.DeserializeObject<MovieResult>(result) : new MovieResult();
        }
    }
}
