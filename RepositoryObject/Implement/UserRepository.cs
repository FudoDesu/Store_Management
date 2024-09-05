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
    public class UserRepository : IUserRepository
    {
        public void Create(User user) => UnitOfWork.Instance.UserDAO.Create(user);

        public Task CreateAsync(User user) => UnitOfWork.Instance.UserDAO.CreateAsync(user);

        public void Delete(int id) => UnitOfWork.Instance.UserDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.UserDAO.DeleteAsync(id);

        public User GetById(int id) => UnitOfWork.Instance.UserDAO.GetById(id);

        public Task<User> GetByIdAsync(int id) => UnitOfWork.Instance.UserDAO.GetByIdAsync(id);

        public List<User> GetList() => UnitOfWork.Instance.UserDAO.GetList();

        public Task<List<User>> GetListAsync() => UnitOfWork.Instance.UserDAO.GetListAsync();

        public User Login(string email, string password) => UnitOfWork.Instance.UserDAO.Login(email, password);

        public Task<User> LoginAsync(string email, string password) => UnitOfWork.Instance.UserDAO.LoginAsync(email, password);

        public void Update(User user) => UnitOfWork.Instance.UserDAO.Update(user);

        public Task UpdateAsync(User user) => UnitOfWork.Instance.UserDAO.UpdateAsync(user);

        public bool ValidateBeforeCreate(User user) => UnitOfWork.Instance.UserDAO.ValidateBeforeCreate(user);
    }
}
