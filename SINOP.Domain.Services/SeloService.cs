using SINOP.Domain.Core.Interfaces.Repositorys;
using SINOP.Domain.Core.Interfaces.Services;
using SINOP.Domain.Entitys;

namespace SINOP.Domain.Services;

public class SeloService : ServiceBase<Selo>, ISeloService
{
    private readonly ISeloRepository _seloRepository;

    public SeloService(ISeloRepository seloRepository) : base(seloRepository)
    {
        _seloRepository = seloRepository;
    }
}