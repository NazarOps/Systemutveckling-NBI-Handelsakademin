using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxExercise
{
    public class GenericBox<T>
    {
        public T innehåll;
        public void SetValue(T value)
        {
            innehåll = value;
        }

        public T GetValue()
        {
            return innehåll;
        }
    }
}
