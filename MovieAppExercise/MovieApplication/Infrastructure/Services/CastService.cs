using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services {
    public class CastService : ICastService {

        private readonly ICastRepository _castRepository;

        public CastService(ICastRepository castRepository) {
            _castRepository = castRepository;
        }

        public async Task<Casts> GetCastDetailsAsync(int id) {
            return await _castRepository.GetByIdAsync(id);
        }

    }
}
