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
    public class GroceryRepository : IGroceryRepository
    {
        public void Create(Grocery grocery) => UnitOfWork.Instance.GroceryDAO.Create(grocery);

        public Task CreateAsync(Grocery grocery) => UnitOfWork.Instance.GroceryDAO.CreateAsync(grocery);

        public void Delete(int id) => UnitOfWork.Instance.GroceryDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.GroceryDAO.DeleteAsync(id);

        public Grocery GetById(int id) => UnitOfWork.Instance.GroceryDAO.GetById(id);

        public Task<Grocery> GetByIdAsync(int id) => UnitOfWork.Instance.GroceryDAO.GetByIdAsync(id);

        public List<Grocery> GetList() => UnitOfWork.Instance.GroceryDAO.GetList();

        public Task<List<Grocery>> GetListAsync() => UnitOfWork.Instance.GroceryDAO.GetListAsync();

        public void Update(Grocery grocery) => UnitOfWork.Instance.GroceryDAO.Update(grocery);

        public Task UpdateAsync(Grocery grocery) => UnitOfWork.Instance.GroceryDAO.UpdateAsync(grocery);
    }
}
