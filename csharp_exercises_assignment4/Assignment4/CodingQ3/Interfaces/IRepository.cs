using Assignment4.CodingQ3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.CodingQ3.Interfaces {
    internal interface IRepository<T> where T : class, IEntity {

        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T? GetById(int id);

    }
}
