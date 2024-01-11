using Microsoft.EntityFrameworkCore;
using SINOP.Domain.Core.Interfaces.Repositorys;

namespace SINOP.Infra.Data.EntityFrameworkCore.Repositorys;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    private readonly DbContextOptions<SINOPContext> _context;

    public RepositoryBase()
    {
        _context = new DbContextOptions<SINOPContext>();
    }

    public async Task Add(TEntity entity)
    {
        using (var data = new SINOPContext(_context))
        {
            await data.Set<TEntity>().AddAsync(entity);
            await data.SaveChangesAsync();
        }
    }

    public async Task Delete(TEntity entity)
    {
        using (var data = new SINOPContext(_context))
        {
            data.Set<TEntity>().Remove(entity);
            await data.SaveChangesAsync();
        }
    }

    public async Task<List<TEntity>> GetAll()
    {
        using (var data = new SINOPContext(_context))
        {
            return await data.Set<TEntity>().ToListAsync();
        }
    }

    public async Task<TEntity> GetById(int id)
    {
        using (var data = new SINOPContext(_context))
        {
            return await data.Set<TEntity>().FindAsync(id);
        }
    }

    public async Task Update(TEntity entity)
    {
        using (var data = new SINOPContext(_context))
        {
            data.Set<TEntity>().Update(entity);
            await data.SaveChangesAsync();
        }
    }
}