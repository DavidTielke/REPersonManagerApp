using System.Collections.Generic;
using System.Linq;
using CrossCutting.Contract.DataClasses;

namespace ConsoleClient.Data
{
    public class CatRepository : ICatRepository
    {
        private static List<Cat> _cats = new List<Cat>();

        public IQueryable<Cat> Query => _cats.AsQueryable();

        public void Add(Cat cat)
        {
            _cats.Add(cat);
        }
    }
}