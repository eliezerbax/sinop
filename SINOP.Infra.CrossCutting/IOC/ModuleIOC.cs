using Autofac;

namespace SINOP.Infra.CrossCutting.IOC;

public class ModuleIOC : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        ConfigurationIOC.Load(builder);
    }
}