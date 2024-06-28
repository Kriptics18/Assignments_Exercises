using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    internal class MyStack<T> {

        private List<T> elements = new List<T>();

        
        public int Count() {
            return elements.Count;
        }

        // Removes and returns the top element of the stack
        public T Pop() {
            if (elements.Count == 0) {
                throw new InvalidOperationException("The stack is empty.");
            }

           
            T topElement = elements[elements.Count - 1];

            
            elements.RemoveAt(elements.Count - 1);

            
            return topElement;
        }

        
        public void Push(T item) {
            elements.Add(item);
        }

    }
}
