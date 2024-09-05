using BusinessObject.Entity;
using DataAcessObject;
using RepositoryObject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Implement
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void Create(OrderDetail orderDetail) => UnitOfWork.Instance.OrderDetailDAO.Create(orderDetail);

        public Task CreateAsync(OrderDetail orderDetail) => UnitOfWork.Instance.OrderDetailDAO.CreateAsync(orderDetail);

        public void Delete(int id) => UnitOfWork.Instance.OrderDetailDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.OrderDetailDAO.DeleteAsync(id);

        public OrderDetail GetById(int id) => UnitOfWork.Instance.OrderDetailDAO.GetById(id);

        public Task<OrderDetail> GetByIdAsync(int id) => UnitOfWork.Instance.OrderDetailDAO.GetByIdAsync(id);

        public List<OrderDetail> GetList() => UnitOfWork.Instance.OrderDetailDAO.GetList();

        public Task<List<OrderDetail>> GetListAsync() => UnitOfWork.Instance.OrderDetailDAO.GetListAsync();

        public void Update(OrderDetail orderDetail) => UnitOfWork.Instance.OrderDetailDAO.Update(orderDetail);  

        public Task UpdateAsync(OrderDetail orderDetail) => UnitOfWork.Instance.OrderDetailDAO.UpdateAsync(orderDetail);    
    }
}
