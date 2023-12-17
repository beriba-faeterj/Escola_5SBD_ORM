using Escola_5SBD_ORM.Domain.Interface.Repository._Base;
using Escola_5SBD_ORM.Domain.Interface.Service._Base;
using Escola_5SBD_ORM.Domain.Model._Base;

namespace Escola_5SBD_ORM.Domain.Service._Base
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseModel
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task Create(TEntity entity)
        {
            await _repository.Create(entity);
        }

        public async Task Delete(TEntity entity)
        {
            await _repository.Delete(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(TEntity entity)
        {
            await _repository.Update(entity);
        }
    }
}
