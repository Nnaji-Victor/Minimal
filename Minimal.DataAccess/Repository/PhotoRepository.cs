using Minimal.DataAccess.Data;
using Minimal.DataAccess.Repository.IRepository;
using Minimal.Models;

namespace Minimal.DataAccess.Repository
{
    public class PhotoRepository : Repository<Photo>, IPhotoRepository
    {
         private readonly ApplicationDbContext _db;
        public PhotoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category category)
        {
            throw new System.NotImplementedException();
        }
    }
}