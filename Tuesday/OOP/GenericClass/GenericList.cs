using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericList<Things> // create a generic class called genericlist
    {
        public List<Things> items = new List<Things>(); // create a generic list that can store any data types <T> can be anything, for example <Things>
            

        public void Add(Things item)             // methods
        {
            items.Add(item);
        }

        public void Remove(Things item)
        {
            items.Remove(item);
        }

        public Things Get(int index)
        {
            return items[index];

        }
    }
}
