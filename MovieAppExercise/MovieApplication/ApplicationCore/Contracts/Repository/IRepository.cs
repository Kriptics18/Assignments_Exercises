using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository {
    public interface IRepository<T> where T : class {

        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task AddMultipleAsync(IEnumerable<T> entities);
        Task RemoveAsync(T entity);
        Task RemoveMultipleAsync(IEnumerable<T> entities);

    }
}
