using System.Linq;
using CrossCutting.Contract.DataClasses;

namespace ConsoleClient.Data
{
    public interface ICatRepository
    {
        IQueryable<Cat> Query { get; }
        public void Add(Cat cat);
    }
}