using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository {
    public class MovieRepository : GenericRepository<Movies>, IMovieRepository {

        private readonly MovieDbContext _dbContext;

        public MovieRepository(MovieDbContext dbContext) : base(dbContext) {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<Movies>> GetHighestGrossingMovies() {
            return await _dbContext.Movies
                                   .OrderByDescending(m => m.Revenue)
                                   .Take(10)
                                   .ToListAsync();
        }

        public async Task<Movies> GetMovieByIdAsync(int id) {
            return await _dbContext.Movies
                                   .Include(m => m.MovieGenres)
                                       .ThenInclude(mg => mg.Genre)
                                   .Include(m => m.MovieCasts)
                                       .ThenInclude(mc => mc.Cast)
                                   .Include(m => m.Trailers)
                                   .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Movies> GetMovieDetailsAsync(int id) {
            return await _dbContext.Movies
                                   .Include(m => m.MovieGenres)
                                       .ThenInclude(mg => mg.Genre)
                                   .Include(m => m.MovieCasts)
                                       .ThenInclude(mc => mc.Cast)
                                   .Include(m => m.Trailers)
                                   .Include(m => m.Reviews)
                                   .AsSplitQuery()
                                   .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<PaginatedResultSet<Movies>> GetMoviesByGenreAsync(int genreId, int pageSize, int pageNumber) {
            var totalMovies = await _dbContext.Movies.CountAsync(m => m.MovieGenres.Any(g => g.GenreId == genreId));
            var movies = await _dbContext.Movies
                .Where(m => m.MovieGenres.Any(g => g.GenreId == genreId))
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PaginatedResultSet<Movies>(movies, pageNumber, pageSize, totalMovies);
        }
    }
}
