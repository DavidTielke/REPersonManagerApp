using System;
using System.Linq;
using ConsoleClient.CrossCutting;
using ConsoleClient.Data;
using ConsoleClient.Logic;
using Ninject;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();

            kernel.Bind<IPersonAnalytics>().To<PersonAnalytics>();
            kernel.Bind<IPersonManager>().To<PersonManager>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
            kernel.Bind<IConfigurator>().To<Configurator>().InSingletonScope();

            var config = kernel.Get<IConfigurator>();
            config.Set("PersonManagement","AgeTreshold", 8);

            var manager = kernel.Get<IPersonManager>();
            var analytics = kernel.Get<IPersonAnalytics>();

            var adults = manager.GetAllAdults();
            var amountAdults = analytics.GetAmountAdults();
            var children = manager.GetAllChildren();
            var amountChildren = analytics.GetAmountChildren();

            Console.WriteLine($"## Erwachsene ({amountAdults}) ##");
            adults.ToList().ForEach(a => Console.WriteLine(a.Name));

            Console.WriteLine($"## Kinder ({amountChildren}) ##");
            children.ToList().ForEach(c => Console.WriteLine(c.Name));
        }
    }
}
