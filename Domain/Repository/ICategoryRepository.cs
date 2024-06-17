using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface ICategoryRepository
    {
        public Task<Category?> GetCategory(string user);
        public Category Save(Category usuario);
        public Task<List<Category>> GetAllCategory();
        public void UpdateCategory(Category category);
    }
}
