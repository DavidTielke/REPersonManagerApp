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
            var workflow = kernel.Get<INewPersonWorkflow>();

            var newPerson = new Person(7, "Lisa", 2);
            workflow.Run(newPerson);

            var adults = manager.GetAllAdults();
            var amountAdults = analytics.GetAmountAdults();
            var children = manager.GetAllChildren();
            var amountChildren = analytics.GetAmountChildren();

            Console.WriteLine($"## Erwachsene ({amountAdults}) ##");
            adults.ToList().ForEach(a => Console.WriteLine($"{a.Name} - Katze: {a.Cat?.Name ?? "keine"}"));

            Console.WriteLine($"## Kinder ({amountChildren}) ##");
            children.ToList().ForEach(c => Console.WriteLine($"{c.Name} - Katze: {c.Cat?.Name ?? "keine"}"));
        }
    }
}
