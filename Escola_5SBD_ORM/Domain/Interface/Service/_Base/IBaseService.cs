﻿using Escola_5SBD_ORM.Domain.Model._Base;

namespace Escola_5SBD_ORM.Domain.Interface.Service._Base
{
    public interface IBaseService<TEntity> where TEntity : BaseModel
    {
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
