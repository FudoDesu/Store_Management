using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IRoleRepository
    {
        List<Role> GetList();
        Task<List<Role>> GetListAsync();
        Role GetById(int id);
        Task<Role> GetByIdAsync(int id);
        void Create(Role role);
        Task CreateAsync(Role role);
        void Update(Role role);
        Task UpdateAsync(Role role);
        void Delete(int id);
        Task DeleteAsync(int id);
        List<Role> GetListForAdminModify();
        Task<List<Role>> GetListForAdminModifyAsync();
    }
}
