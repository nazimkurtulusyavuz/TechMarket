using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int Id);
        Task<List<T>> ListAllAsync();
        Task<List<T>> ListAsync(ISpecification<T> specification);
        Task<T> AddAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task<int> CountAsync(ISpecification<T> specification);
        Task<T> FirstAsync(ISpecification<T> specification);
        Task<T> FirstOrDefaultAsync(ISpecification<T> specification);
    }
}
