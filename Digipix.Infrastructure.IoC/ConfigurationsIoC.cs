using Digipix.ApplicationService.Implementations;
using Digipix.ApplicationService.Interfaces;
using Digipix.Infrastructure.Service.Implementations;
using Digipix.Infrastructure.Service.Interfaces;
using Ninject;

namespace Digipix.Infrastructure.IoC
{
    public static class ConfigurationsIoC
    {

        public static void RegisterServices(IKernel kernel)
        {
            RegisterInfrastructureService(kernel);

            RegisterApplicationService(kernel);
        }

        private static void RegisterInfrastructureService(IKernel kernel)
        {
            kernel.Bind<IEnderecoService>().To<EnderecoService>();
        }

        private static void RegisterApplicationService(IKernel kernel)
        {
            kernel.Bind<IEnderecoApplicationService>().To<EnderecoApplicationService>();
        }
    }
}
