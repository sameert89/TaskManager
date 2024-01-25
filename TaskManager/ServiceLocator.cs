using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        public static void Register<T>(T implementation)
        {
            _services[typeof(T)] = implementation;
        }

        public static T Resolve<T>()
        {
            if (_services.TryGetValue(typeof(T), out var implementation))
            {
                return (T)implementation;
            }

            throw new InvalidOperationException($"No implementation registered for interface {typeof(T)}");
        }
    }
}
