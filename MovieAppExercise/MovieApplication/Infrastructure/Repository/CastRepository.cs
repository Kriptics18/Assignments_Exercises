using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository {
    public class CastRepository : GenericRepository<Casts>, ICastRepository {

        private readonly MovieDbContext _dbContext;

        public CastRepository(MovieDbContext dbContext) : base(dbContext) {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public override async Task<Casts> GetByIdAsync(int id) {
            return await _dbContext.Casts
                .Include(c => c.MovieCasts)
                    .ThenInclude(mc => mc.Movie)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}
