using BusinessObject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessObject
{
    public class GenericDAO<T> where T : class
    {
        protected StoreManagementContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericDAO()
        {
            _context = new StoreManagementContext();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetList()
        {
            return _dbSet.ToList();
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public async Task<int> CreateAsync(T entity)
        {
            _dbSet.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync();
        }
     }
}
