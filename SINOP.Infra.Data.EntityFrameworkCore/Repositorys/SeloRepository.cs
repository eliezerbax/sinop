using SINOP.Domain.Core.Interfaces.Repositorys;
using SINOP.Domain.Entitys;

namespace SINOP.Infra.Data.EntityFrameworkCore.Repositorys;

public class SeloRepository : RepositoryBase<Selo>, ISeloRepository
{
    private readonly SINOPContext _context;

    public SeloRepository(SINOPContext context)
    {
        _context = context;
    }
}