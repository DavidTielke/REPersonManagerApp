using System.Linq;

namespace ConsoleClient.Data
{
    internal interface IPersonRepository
    {
        IQueryable<Person> Query { get; }
    }
}