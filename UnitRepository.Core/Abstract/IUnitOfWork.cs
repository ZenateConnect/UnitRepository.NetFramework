using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitRepository.Core.Abstract
{
    public interface IUnitOfWork<TDbContext> where TDbContext : DbContext
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IGenericRepository<TEntity> CreateRepositoryInstance<TEntity>(TDbContext dbContext) where TEntity : class;
    }
}
