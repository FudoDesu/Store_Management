using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IOrderRepository
    {
        List<Order> GetList();
        Task<List<Order>> GetListAsync();
        Order GetById(int id);
        Task<Order> GetByIdAsync(int id);
        void Create(Order order);
        Task CreateAsync(Order order);
        void Update(Order order);
        Task UpdateAsync(Order order);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
