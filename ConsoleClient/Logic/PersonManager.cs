using System.Linq;
using ConsoleClient.Data;

namespace ConsoleClient.Logic
{
    class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _repository;

        public PersonManager(IPersonRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Person> GetAllAdults()
        {
            return _repository.Query.Where(p => p.Age >= 18);
        }

        public IQueryable<Person> GetAllChildren()
        {
            return _repository.Query.Where(p => p.Age < 18);
        }
    }
}