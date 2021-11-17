using System;
using ConsoleClient.CrossCutting;
using ConsoleClient.Data;
using ConsoleClient.Logic;
using Ninject;

namespace Mappings
{
    public class KernelInitializer
    {
        public void Initialize(IKernel kernel)
        {
            kernel.Bind<IPersonAnalytics>().To<PersonAnalytics>();
            kernel.Bind<IPersonManager>().To<PersonManager>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
            kernel.Bind<IConfigurator>().To<Configurator>().InSingletonScope();
        }
    }
}
