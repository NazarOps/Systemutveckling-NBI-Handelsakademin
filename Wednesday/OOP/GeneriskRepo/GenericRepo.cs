using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GeneriskRepo
{
    public class GenericRepo<T>
    {
        List<T> GeneriskLista = new List<T>();

        //        Bygg en generisk klass Repository<T> som simulerar en databas:
        //Metoder: Add(T item), Find(Func<T, bool> predicate), GetAll()
        // 💡 Testa med olika typer: Student, Product, Book.


        public void Add(T item)
        {
            GeneriskLista.Add(item);
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            return GeneriskLista.Where(predicate).ToList();
        }

        //public List<T> GetAll()
        //{

        //}
    }
}
