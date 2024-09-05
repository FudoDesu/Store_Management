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
    public class OrderRepository : IOrderRepository
    {
        public void Create(Order order) => UnitOfWork.Instance.OrderDAO.Create(order);

        public Task CreateAsync(Order order) => UnitOfWork.Instance.OrderDAO.CreateAsync(order);

        public void Delete(int id) => UnitOfWork.Instance.OrderDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.OrderDAO.DeleteAsync(id);

        public Order GetById(int id) => UnitOfWork.Instance.OrderDAO.GetById(id);

        public Task<Order> GetByIdAsync(int id) => UnitOfWork.Instance.OrderDAO.GetByIdAsync(id);

        public List<Order> GetList() => UnitOfWork.Instance.OrderDAO.GetList();

        public Task<List<Order>> GetListAsync() => UnitOfWork.Instance.OrderDAO.GetListAsync();

        public void Update(Order order) => UnitOfWork.Instance.OrderDAO.Update(order);

        public Task UpdateAsync(Order order) => UnitOfWork.Instance.OrderDAO.UpdateAsync(order);    
    }
}
