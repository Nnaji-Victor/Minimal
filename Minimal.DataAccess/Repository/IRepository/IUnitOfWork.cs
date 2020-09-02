using System;
namespace Minimal.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
         ICategoryRepository Category {get;}
         IPhotoRepository Photo {get;}
         ISP_Call SP_Call {get;}
         void Save();
    }
}