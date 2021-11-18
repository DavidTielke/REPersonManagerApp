using System.Linq;

namespace ConsoleClient.Logic
{
    public interface IPersonManager
    {
        IQueryable<Person> GetAllAdults();
        IQueryable<Person> GetAllChildren();
        void Add(Person person);
    }
}