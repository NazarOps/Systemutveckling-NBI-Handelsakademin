using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericList<T> // create a generic class called genericlist
    {
        public List<T> items = new List<T>(); // create a generic list that can store any data types
            

        public void Add(T item)             // methods
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public T Get(int index)
        {
            return items[index];

        }
    }
}
