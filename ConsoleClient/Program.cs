using System;
using System.Linq;
using ConsoleClient.CrossCutting;
using ConsoleClient.Data;
using ConsoleClient.Logic;
using Mappings;
using Ninject;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            new KernelInitializer().Initialize(kernel);

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
