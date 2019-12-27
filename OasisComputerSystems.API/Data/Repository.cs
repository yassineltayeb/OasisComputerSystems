using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OasisComputerSystems.API.Core;

namespace OasisComputerSystems.API.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;
        private IDbContextTransaction _transaction;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async void BeginTransaction()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async void Commit()
        {
            await _transaction.CommitAsync();
        }

        public async void Rollback()
        {
           await _transaction.RollbackAsync();
        }
    }
}