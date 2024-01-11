namespace SINOP.Domain.Core.Interfaces.Services;

public interface IServiceBase<TEntity> where TEntity : class
{
    Task Add(TEntity entity);

    Task Update(TEntity entity);

    Task Delete(TEntity entity);

    Task<List<TEntity>> GetAll();

    Task<TEntity> GetById(int Id);
}