using Escola_5SBD_ORM.Domain.Model._Base;
using Microsoft.AspNetCore.Mvc;

namespace Escola_5SBD_ORM.Domain.Interface.Repository._Base
{
    public interface IBaseRepository<TEntity> where TEntity : BaseModel
    {
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();

    }
}
