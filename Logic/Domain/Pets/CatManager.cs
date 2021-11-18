using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.Data;
using ConsoleClient.Logic;
using CrossCutting.Contract.DataClasses;

namespace Logic.Domain.Pets
{
    public class CatManager : ICatManager
    {
        private readonly ICatRepository _repository;

        public CatManager(ICatRepository repository)
        {
            _repository = repository;
        }

        public void Add(Cat cat)
        {
            _repository.Add(cat);
        }
    }
}
