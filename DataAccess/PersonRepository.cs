using System.Collections.Generic;
using System.Linq;

namespace ConsoleClient.Data
{
    public class PersonRepository : IPersonRepository
    {
        private static List<Person> _persons = new List<Person>()
        {
            new Person(1, "David",37),
            new Person(2, "Lena",34),
            new Person(3, "Maximilian",8),
            new Person(4, "Hasi",8),
            new Person(5, "Teddy",7),
        };

        public IQueryable<Person> Query => _persons.AsQueryable();

        public void Add(Person person)
        {
            _persons.Add(person);
        }
    }
}