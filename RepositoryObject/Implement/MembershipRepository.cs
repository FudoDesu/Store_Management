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
    public class MembershipRepository : IMembershipRepository
    {
        public void Create(Membership membeship) => UnitOfWork.Instance.MembershipDAO.Create(membeship);

        public Task CreateAsync(Membership membership) => UnitOfWork.Instance.MembershipDAO.CreateAsync(membership);

        public void Delete(int id) => UnitOfWork.Instance.MembershipDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.MembershipDAO.DeleteAsync(id);

        public Membership GetById(int id) => UnitOfWork.Instance.MembershipDAO.GetById(id);

        public Task<Membership> GetByIdAsync(int id) => UnitOfWork.Instance.MembershipDAO.GetByIdAsync(id);

        public List<Membership> GetList() => UnitOfWork.Instance.MembershipDAO.GetList();

        public Task<List<Membership>> GetListAsync() => UnitOfWork.Instance.MembershipDAO.GetListAsync();

        public void Update(Membership membership) => UnitOfWork.Instance.MembershipDAO.Update(membership);

        public Task UpdateAsync(Membership membership) => UnitOfWork.Instance.MembershipDAO.UpdateAsync(membership);
    }
}
