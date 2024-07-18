using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastructure.Services {
    public class MovieService : IMovieService {

        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository) {
            _movieRepository = movieRepository;
        }

        public IEnumerable<MovieCardModel> GetTestMovieCards() {
            
            return new List<MovieCardModel>
            {
                new MovieCardModel { Id = 1, Title = "Movie 1", PosterUrl = "url1" },
                new MovieCardModel { Id = 2, Title = "Movie 2", PosterUrl = "url2" }
            };
        }

        public async Task<Movies> GetMovieDetailsAsync(int id) {
            return await _movieRepository.GetMovieDetailsAsync(id);
        }

    }
}
