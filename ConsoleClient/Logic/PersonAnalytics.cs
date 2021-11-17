using System.Linq;

namespace ConsoleClient.Logic
{
    class PersonAnalytics : IPersonAnalytics
    {
        private readonly IPersonManager _manager;

        public PersonAnalytics(IPersonManager manager)
        {
            _manager = manager;
        }

        public int GetAmountAdults()
        {
            return _manager.GetAllAdults().Count();
        }

        public int GetAmountChildren()
        {
            return _manager.GetAllChildren().Count();
        }
    }
}