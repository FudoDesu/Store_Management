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
    public class CategoryRepository : Interface.ICategoryRepository
    {
        public void Create(Category category) => UnitOfWork.Instance.CategoryDAO.Create(category);

        public Task CreateAsync(Category category) => UnitOfWork.Instance.CategoryDAO.CreateAsync(category);

        public void Delete(int id) => UnitOfWork.Instance.CategoryDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.CategoryDAO.DeleteAsync(id);

        public Category GetById(int id) => UnitOfWork.Instance.CategoryDAO.GetById(id);

        public Task<Category> GetByIdAsync(int id) => UnitOfWork.Instance.CategoryDAO.GetByIdAsync(id);

        public List<Category> GetList() => UnitOfWork.Instance.CategoryDAO.GetList();

        public Task<List<Category>> GetListAsync() => UnitOfWork.Instance.CategoryDAO.GetListAsync();

        public void Update(Category category) => UnitOfWork.Instance.CategoryDAO.Update(category);

        public Task UpdateAsync(Category category) => UnitOfWork.Instance.CategoryDAO.UpdateAsync(category);
    }
}
