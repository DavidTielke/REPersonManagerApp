using System.Linq;

namespace ConsoleClient.Data
{
    public interface IPersonRepository
    {
        IQueryable<Person> Query { get; }
        public void Add(Person person);
    }
}