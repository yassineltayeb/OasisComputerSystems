using System.Collections.Generic;
using System.Threading.Tasks;

namespace OasisComputerSystems.API.Core
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(); 
        Task<T> Get(int id);
        void Add(T entity);
        void Delete(T entity);

        void BeginTransaction();
        Task<bool> SaveAll();
        void Commit();
        void Rollback();
    }
}