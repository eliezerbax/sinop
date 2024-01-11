namespace SINOP.Application.Interfaces;

public interface IAppServiceBase<TEntity> where TEntity : class
{
    Task Add(TEntity entity);

    Task Update(TEntity entity);

    Task Delete(TEntity entity);

    Task<List<TEntity>> GetAll();

    Task<TEntity> GetById(int Id);
}