using Minimal.Models;

namespace Minimal.DataAccess.Repository.IRepository
{
    public interface IPhotoRepository : IRepository<Photo>
    {
         void Update(Category category);
    }
}