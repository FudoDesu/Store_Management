using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IMembershipRepository
    {
        List<Membership> GetList();
        Task<List<Membership>> GetListAsync();
        Membership GetById(int id);
        Task<Membership> GetByIdAsync(int id);
        void Create(Membership membeship);
        Task CreateAsync(Membership membership);
        void Update(Membership membership);
        Task UpdateAsync(Membership membership);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
