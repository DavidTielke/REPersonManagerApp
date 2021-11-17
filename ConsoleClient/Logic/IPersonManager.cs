using System.Linq;

namespace ConsoleClient.Logic
{
    internal interface IPersonManager
    {
        IQueryable<Person> GetAllAdults();
        IQueryable<Person> GetAllChildren();
    }
}