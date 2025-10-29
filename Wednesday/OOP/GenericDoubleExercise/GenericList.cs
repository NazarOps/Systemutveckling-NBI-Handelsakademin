using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoubleExercise
{
    public class GenericList
    {
        
            

        public List<T> Duplicate<T>(T item)
        {
            List<T> DuplicatedList = new List<T>();
            DuplicatedList.Add(item);
            DuplicatedList.Add(item);
            return DuplicatedList;
        }

    }
}
