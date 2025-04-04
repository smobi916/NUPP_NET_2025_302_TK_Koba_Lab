using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PublicTransit.PublicTransit.Common
{
    public class CrudService<T> : ICrudService<T>
    {
        private readonly Dictionary<Guid, T> _storage = new Dictionary<Guid, T>();

        public void Create(T element)
        {
            var propertyInfo = typeof(T).GetProperty("Id");
            if (propertyInfo != null)
            {
                var id = (Guid)propertyInfo.GetValue(element);
                _storage[id] = element;
            }
        }

        public T Read(Guid id)
        {
            return _storage.ContainsKey(id) ? _storage[id] : default;
        }

        public IEnumerable<T> ReadAll()
        {
            return _storage.Values;
        }

        public void Update(T element)
        {
            var propertyInfo = typeof(T).GetProperty("Id");
            if (propertyInfo != null)
            {
                var id = (Guid)propertyInfo.GetValue(element);
                _storage[id] = element;
            }
        }

        public void Remove(T element)
        {
            var propertyInfo = typeof(T).GetProperty("Id");
            if (propertyInfo != null)
            {
                var id = (Guid)propertyInfo.GetValue(element);
                _storage.Remove(id);
            }
        }

        // Методи для збереження та завантаження
        public void Save(string filePath)
        {
            var json = JsonSerializer.Serialize(_storage);
            File.WriteAllText(filePath, json);
        }

        public void Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                _storage.Clear();
                var loadedData = JsonSerializer.Deserialize<Dictionary<Guid, T>>(json);
                foreach (var item in loadedData)
                {
                    _storage[item.Key] = item.Value;
                }
            }
        }
    }

}
