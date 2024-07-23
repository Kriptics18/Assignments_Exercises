using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository {
    public class GenreRepository : GenericRepository<Genres>, IGenreRepository {

        private readonly MovieDbContext _dbContext;

        public GenreRepository(MovieDbContext dbContext) : base(dbContext) {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

    }
}
