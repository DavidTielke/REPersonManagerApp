using System.Collections.Generic;

namespace ConsoleClient.CrossCutting
{
    public class Configurator : IConfigurator
    {
        private readonly Dictionary<string, object> _items;

        public Configurator()
        {
            _items = new Dictionary<string, object>();
        }

        private string ComposeKey(string category, string key) => $"{category}.{key}";

        public T Get<T>(string category, string key)
            => (T)_items[ComposeKey(category, key)];

        public void Set<T>(string category, string key, T value) => _items[ComposeKey(category, key)] = value;
    }
}