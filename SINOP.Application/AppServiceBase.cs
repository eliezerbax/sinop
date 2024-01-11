using Serilog;
using SINOP.Application.Interfaces;
using SINOP.Domain.Core.Interfaces.Services;

namespace SINOP.Application;

public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
{
    private readonly IServiceBase<TEntity> _service;
    public AppServiceBase(IServiceBase<TEntity> service)
    {
        _service = service;
    }

    public void Update(TEntity entity)
    {
        _service.Update(entity);
    }

    async Task IAppServiceBase<TEntity>.Add(TEntity entity)
    {
        await _service.Add(entity);
    }

    async Task IAppServiceBase<TEntity>.Delete(TEntity entity)
    {
        await _service.Delete(entity);
    }

    async Task<List<TEntity>> IAppServiceBase<TEntity>.GetAll()
    {
        return await _service.GetAll();
    }

    async Task<TEntity> IAppServiceBase<TEntity>.GetById(int Id)
    {
        return await _service.GetById(Id);
    }

    async Task IAppServiceBase<TEntity>.Update(TEntity entity)
    {
        await _service.Update(entity);
    }
}