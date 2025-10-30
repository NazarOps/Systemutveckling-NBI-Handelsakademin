using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class MyList<T>
    {
        List<T> MyGenericList = new List<T>();




        public void PutItemsInList(T item)
        {
            MyGenericList.Add(item);
        }

        public void ShowItemsInList()
        {
            foreach (var thing in MyGenericList)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
