using Minimal.Models;

namespace Minimal.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
         void Update(Category category);
    }
}