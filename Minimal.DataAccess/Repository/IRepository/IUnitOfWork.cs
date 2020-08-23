using System;
namespace Minimal.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
         ICategoryRepository Category {get;}
         ISP_Call SP_Call {get;}
    }
}