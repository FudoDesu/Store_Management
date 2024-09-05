using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IUserRepository
    {
        List<User> GetList();
        Task<List<User>> GetListAsync();
        User GetById(int id);
        Task<User> GetByIdAsync(int id);
        void Create(User user);
        Task CreateAsync(User user);
        void Update(User user);
        Task UpdateAsync(User user);
        void Delete(int id);
        Task DeleteAsync(int id);
        User Login(string email, string password);
        Task<User> LoginAsync(string email, string password);
        bool ValidateBeforeCreate(User user);
    }
}
