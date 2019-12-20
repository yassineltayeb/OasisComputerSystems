using System.Collections.Generic;
using System.Threading.Tasks;

namespace OasisComputerSystems.API.Data
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(); 
        Task<T> Get(int id);
        void Add(T entity);
        void Delete(T entity);
        Task<bool> SaveAll();
    }
}