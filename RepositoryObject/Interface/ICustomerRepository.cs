using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface ICustomerRepository
    {
        List<Customer> GetList();
        Task<List<Customer>> GetListAsync();
        Customer GetById(int id);
        Task<Customer> GetByIdAsync(int id);
        void Create(Customer customer);
        Task CreateAsync(Customer customer);
        void Update(Customer customer);
        Task UpdateAsync(Customer customer);
        void Delete(int id);
        Task DeleteAsync(int id);
        Customer GetByUserId (int userId);
        Task<Customer> GetByUserIdAsync(int userId);
    }
}
