using SINOP.Domain.Core.Interfaces.Repositorys;
using SINOP.Domain.Core.Interfaces.Services;

namespace SINOP.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        async Task IServiceBase<TEntity>.Add(TEntity entity)
        {
            await _repository.Add(entity);
        }

        async Task IServiceBase<TEntity>.Delete(TEntity entity)
        {
            await _repository.Delete(entity);
        }

        async Task<List<TEntity>> IServiceBase<TEntity>.GetAll()
        {
            return await _repository.GetAll();
        }

        async Task<TEntity> IServiceBase<TEntity>.GetById(int id)
        {
            return await _repository.GetById(id);
        }

        async Task IServiceBase<TEntity>.Update(TEntity entity)
        {
            await _repository.Update(entity);
        }
    }
}