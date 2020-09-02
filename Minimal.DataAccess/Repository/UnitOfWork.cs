using Minimal.DataAccess.Data;
using Minimal.DataAccess.Repository.IRepository;
using Minimal.Models;

namespace Minimal.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Photo = new PhotoRepository(_db);
            SP_Call = new SP_Call(_db);

        }

        public ICategoryRepository Category {get; private set;}
        public IPhotoRepository Photo {get; private set;}
        public ISP_Call SP_Call {get; private set;}

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}