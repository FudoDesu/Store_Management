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
    public class CustomerRepository : ICustomerRepository
    {
        public void Create(Customer customer) => UnitOfWork.Instance.CustomerDAO.Create(customer);

        public Task CreateAsync(Customer customer) => UnitOfWork.Instance.CustomerDAO.UpdateAsync(customer);

        public void Delete(int id) => UnitOfWork.Instance.CustomerDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.CustomerDAO.DeleteAsync(id);

        public Customer GetById(int id) => UnitOfWork.Instance.CustomerDAO.GetById(id);

        public Task<Customer> GetByIdAsync(int id) => UnitOfWork.Instance.CustomerDAO.GetByIdAsync(id);

        public Customer GetByUserId(int userId) => UnitOfWork.Instance.CustomerDAO.GetByUserId(userId);

        public Task<Customer> GetByUserIdAsync(int userId) => UnitOfWork.Instance.CustomerDAO.GetByUserIdAsync(userId);

        public List<Customer> GetList() => UnitOfWork.Instance.CustomerDAO.GetList();

        public Task<List<Customer>> GetListAsync() => UnitOfWork.Instance.CustomerDAO.GetListAsync();

        public void Update(Customer customer) => UnitOfWork.Instance.CustomerDAO.Update(customer);

        public Task UpdateAsync(Customer customer) => UnitOfWork.Instance.CustomerDAO.UpdateAsync(customer);
    }
}
