using Escola_5SBD_ORM.Domain.Interface.Repository._Base;
using Escola_5SBD_ORM.Domain.Model;
using Escola_5SBD_ORM.Domain.Model._Base;
using Microsoft.EntityFrameworkCore;

namespace Escola_5SBD_ORM.Data.Repository._Base
{
    public class BaseRepository<TDatabaseContext, TEntity> : IBaseRepository<TEntity>
            where TEntity : BaseModel
            where TDatabaseContext : DbContext

    {
        protected readonly TDatabaseContext _databaseContext;

        public BaseRepository(TDatabaseContext context)
        {
            this._databaseContext = context;
        }
        public async Task Create(TEntity entity)
        {
            await _databaseContext.Set<TEntity>().AddAsync(entity);

            await _databaseContext.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _databaseContext.Set<TEntity>().Remove(entity);

            await _databaseContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _databaseContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _databaseContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity)
        {
            _databaseContext.Entry(entity).State = EntityState.Modified;

            await _databaseContext.SaveChangesAsync();
        }
    }
}
