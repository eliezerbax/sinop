using Autofac;
using SINOP.Application;
using SINOP.Application.Interfaces;
using SINOP.Domain.Core.Interfaces.Repositorys;
using SINOP.Domain.Core.Interfaces.Services;
using SINOP.Domain.Services;
using SINOP.Infra.Data.EntityFrameworkCore.Repositorys;

namespace SINOP.Infra.CrossCutting.IOC;

public class ConfigurationIOC
{
    public static void Load(ContainerBuilder builder)
    {
        builder.RegisterType<SeloAppService>().As<ISeloAppService>();
        builder.RegisterType<SeloService>().As<ISeloService>();
        builder.RegisterType<SeloRepository>().As<ISeloRepository>();
    }
}