using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface ICategoryRepository
    {
        List<Category> GetList();
        Task<List<Category>> GetListAsync();
        Category GetById(int id);
        Task<Category> GetByIdAsync(int id);
        void Create(Category category);
        Task CreateAsync(Category category);
        void Update(Category category);
        Task UpdateAsync(Category category);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
