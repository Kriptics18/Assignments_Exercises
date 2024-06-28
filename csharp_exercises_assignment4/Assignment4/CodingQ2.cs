using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment4 {
    internal class MyList<T> {

        private T[] elements;
        private int count;

        public MyList() {
            elements = new T[4];
            count = 0;
        }

        
        public void Add(T element) {
            EnsureCapacity();
            elements[count] = element;
            count++;
        }

        
        public T Remove(int index) {
            if (index < 0 || index >= count) {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            T element = elements[index];
            for (int i = index; i < count - 1; i++) {
                elements[i] = elements[i + 1];
            }
            count--;
            return element;
        }

        
        public bool Contains(T element) {
            for (int i = 0; i < count; i++) {
                if (Equals(elements[i], element)) {
                    return true;
                }
            }
            return false;
        }

        
        public void Clear() {
            elements = new T[4];
            count = 0;
        }

        
        public void InsertAt(T element, int index) {
            if (index < 0 || index > count) {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            EnsureCapacity();
            for (int i = count; i > index; i--) {
                elements[i] = elements[i - 1];
            }
            elements[index] = element;
            count++;
        }

        
        public void DeleteAt(int index) {
            if (index < 0 || index >= count) {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            for (int i = index; i < count - 1; i++) {
                elements[i] = elements[i + 1];
            }
            count--;
        }

        
        public T Find(int index) {
            if (index < 0 || index >= count) {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            return elements[index];
        }

        
        public int Count() {
            return count;
        }

        
        private void EnsureCapacity() {
            if (count == elements.Length) {
                T[] newElements = new T[elements.Length * 2];
                Array.Copy(elements, newElements, elements.Length);
                elements = newElements;
            }
        }

    }
}
