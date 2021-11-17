using System;

namespace ConsoleClient.CrossCutting
{
    public interface IConfigurator
    {
        public T Get<T>(string category, string key);
        public void Set<T>(string category, string key, T value);
    }
}