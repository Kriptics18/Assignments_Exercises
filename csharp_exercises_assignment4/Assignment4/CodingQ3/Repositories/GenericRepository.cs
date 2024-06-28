using Assignment4.CodingQ3.Entities;
using Assignment4.CodingQ3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.CodingQ3.Repositories {
    internal class GenericRepository<T> : IRepository<T> where T : class, IEntity  {

        private readonly List<T> _dataSource; // Simulating an in-memory data source

        public GenericRepository() {
            _dataSource = new List<T>();
        }

        
        public void Add(T item) {
            if (item == null) {
                throw new ArgumentNullException(nameof(item));
            }

            // Assign the ID of the to-be-stored item based on the highest ID in the data source
            if (_dataSource.Any()) {
                item.Id = _dataSource.Max(e => e.Id) + 1;
            } else {
                item.Id = 1;
            }

            _dataSource.Add(item);
        }

        
        public void Remove(T item) {
            if (item == null) {
                throw new ArgumentNullException(nameof(item));
            }

            _dataSource.Remove(item);
        }

        
        public void Save() {
            // With a real database, this method would persist the changes to the database.
            // Here, since we are limited to in-memory storage in the form of a list, we simulate it by just maintaining the in-memory list.
        }

        
        public IEnumerable<T> GetAll() {
            return _dataSource;
        }

        
        public T? GetById(int id) {
            foreach (var item in _dataSource) {

                if (item.Id == id) {
                    return item;
                }

            }
            return null;
        }

    }
}
