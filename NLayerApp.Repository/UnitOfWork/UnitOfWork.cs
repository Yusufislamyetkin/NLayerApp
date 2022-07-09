using NLayerApp.Core.IUnitOfWork;
using NLayerApp.Repository.Context;

namespace NLayerApp.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        AppDbContext _db;

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _db.SaveChangesAsync();
        }
    }
}
