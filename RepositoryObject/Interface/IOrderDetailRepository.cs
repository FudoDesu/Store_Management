using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetList();
        Task<List<OrderDetail>> GetListAsync();
        OrderDetail GetById(int id);
        Task<OrderDetail> GetByIdAsync(int id);
        void Create(OrderDetail orderDetail);
        Task CreateAsync(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        Task UpdateAsync(OrderDetail orderDetail);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
