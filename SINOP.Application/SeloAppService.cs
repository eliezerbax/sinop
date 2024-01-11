using Serilog;
using SINOP.Application.Interfaces;
using SINOP.Domain.Core.Interfaces.Services;
using SINOP.Domain.Entitys;

namespace SINOP.Application;

public class SeloAppService : AppServiceBase<Selo>, ISeloAppService
{
    private readonly ISeloService _seloService;
   

    public SeloAppService(ISeloService seloService) : base(seloService)
    {
        _seloService = seloService;
    }
}