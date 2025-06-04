using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace WarShips.Common
{
    public class InMemoryCrudService<T> : ICrudService<T> where T : IEntity
    {
        private readonly Dictionary<Guid, T> _store = new();

        public void Create(T element)
        {
            _store[element.Id] = element;
        }

        public T Read(Guid id)
        {
            return _store.TryGetValue(id, out var item) ? item : default;
        }

        public IEnumerable<T> ReadAll()
        {
            return _store.Values;
        }

        public void Update(T element)
        {
            if (_store.ContainsKey(element.Id))
                _store[element.Id] = element;
        }

        public void Remove(T element)
        {
            _store.Remove(element.Id);
        }
    }
}
