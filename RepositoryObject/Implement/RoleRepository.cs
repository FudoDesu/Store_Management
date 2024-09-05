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
    public class RoleRepository : IRoleRepository
    {
        public void Create(Role role) => UnitOfWork.Instance.RoleDAO.Create(role);

        public Task CreateAsync(Role role) => UnitOfWork.Instance.RoleDAO.CreateAsync(role);    

        public void Delete(int id) => UnitOfWork.Instance.RoleDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.RoleDAO.DeleteAsync(id);

        public Role GetById(int id) => UnitOfWork.Instance.RoleDAO.GetById(id);

        public Task<Role> GetByIdAsync(int id) => UnitOfWork.Instance.RoleDAO.GetByIdAsync(id);

        public List<Role> GetList() => UnitOfWork.Instance.RoleDAO.GetList();

        public Task<List<Role>> GetListAsync() => UnitOfWork.Instance.RoleDAO.GetListAsync();

        public List<Role> GetListForAdminModify() => UnitOfWork.Instance.RoleDAO.GetListForAdminModify();

        public Task<List<Role>> GetListForAdminModifyAsync() => UnitOfWork.Instance.RoleDAO.GetListForAdminModifyAsync();

        public void Update(Role role) => UnitOfWork.Instance.RoleDAO.Update(role);

        public Task UpdateAsync(Role role) => UnitOfWork.Instance.RoleDAO.UpdateAsync(role);
    }
}
