using System.Linq;
using ConsoleClient.CrossCutting;
using ConsoleClient.Data;

namespace ConsoleClient.Logic
{
    public class PersonManager : IPersonManager
    {
        private const string CATEGORY = "PersonManagement";
        private const string AGETRESHOLD = "AgeTreshold";
        private readonly IPersonRepository _repository;
        private readonly IConfigurator _config;
        private readonly int AgeTreshold;

        public PersonManager(IPersonRepository repository, IConfigurator config)
        {
            _repository = repository;
            _config = config;
            AgeTreshold = config.Get<int>(CATEGORY, AGETRESHOLD);
        }

        public IQueryable<Person> GetAllAdults()
        {
            return _repository.Query.Where(p => p.Age >= AgeTreshold);
        }

        public IQueryable<Person> GetAllChildren()
        {
            return _repository.Query.Where(p => p.Age < AgeTreshold);
        }

        public void Add(Person person)
        {
            _repository.Add(person);
        }
    }
}