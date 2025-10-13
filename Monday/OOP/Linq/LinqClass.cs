using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class LinqClass
    {
        public void CreateList()
        {
            
            List<Item> items = new List<Item>
            {
                new Item { Name = "Apples", Price = 50 },
                new Item { Name = "Oranges", Price = 30 },
                new Item { Name = "Pear", Price = 10 }
            };

            // Sort descending by price
            var sortedItems = items.OrderByDescending(i => i.Price);

            foreach (var item in sortedItems)
            {
                Console.WriteLine($"{item.Name} - {item.Price}");
            }
        }
    }

    // Define your Item class here
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
