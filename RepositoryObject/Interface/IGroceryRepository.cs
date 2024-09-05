using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IGroceryRepository
    {
        List<Grocery> GetList();
        Task<List<Grocery>> GetListAsync();
        Grocery GetById(int id);
        Task<Grocery> GetByIdAsync(int id);
        void Create(Grocery grocery);
        Task CreateAsync(Grocery grocery);
        void Update(Grocery grocery);
        Task UpdateAsync(Grocery grocery);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
