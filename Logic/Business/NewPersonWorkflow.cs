using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient;
using ConsoleClient.Logic;
using CrossCutting.Contract.DataClasses;

namespace Logic.Business
{
    public class NewPersonWorkflow : INewPersonWorkflow
    {
        private readonly IPersonManager _personManager;
        private readonly ICatManager _catManager;

        public NewPersonWorkflow(IPersonManager personManager, ICatManager catManager)
        {
            _personManager = personManager;
            _catManager = catManager;
        }

        public void Run(Person person)
        {
            var cat = new Cat{Name = "Egon"};
            person.Cat = cat;

            _catManager.Add(cat);
            _personManager.Add(person);
        }
    }
}
