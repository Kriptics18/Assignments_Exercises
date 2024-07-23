using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services {
    public class GenreService : IGenreService {

        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository) {
            _genreRepository = genreRepository ?? throw new ArgumentNullException(nameof(genreRepository));
        }

        public async Task<IEnumerable<Genres>> GetAllGenresAsync() {
            return await _genreRepository.GetAllAsync();
        }

        public async Task<Genres> GetGenreByIdAsync(int id) {
            return await _genreRepository.GetByIdAsync(id);
        }
    }
}
