using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
    public interface IMovieRepository : IRepository<Movies> {
        Task<IEnumerable<Movies>> GetHighestGrossingMovies();

        Task<Movies> GetMovieByIdAsync(int id);

        Task<Movies> GetMovieDetailsAsync(int id);

    }
}
