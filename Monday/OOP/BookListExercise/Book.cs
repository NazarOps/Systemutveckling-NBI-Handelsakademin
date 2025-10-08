using System;
using System.Collections.Generic;

namespace BookListExercise
{
    public class Book
    {
        public string Title;
        public string Author;
        public int YearPublished;

        // Make a list that holds all books
        List<Book> books = new List<Book>();

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nHello, welcome to the library!");
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. Show all books");
                Console.WriteLine("3. Search for a book");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    AddBook();
                }
                else if (choice == 2)
                {
                    ShowBooks();
                }
                else if (choice == 3)
                {
                    SearchBook();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }
        }

        private void AddBook()
        {
            Console.Write("What's the book called? ");
            string title = Console.ReadLine();

            Console.Write("What's the author called? ");
            string author = Console.ReadLine();

            Console.Write("What year was it published? ");
            int year = Convert.ToInt32(Console.ReadLine());

            Book newBook = new Book
            {
                Title = title,
                Author = author,
                YearPublished = year
            };

            books.Add(newBook);

            Console.WriteLine($"Book '{title}' added successfully!");
        }

        private void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books have been added yet.");
                return;
            }

            Console.WriteLine("\n--- Book List ---");
            foreach (Book b in books)
            {
                Console.WriteLine($"Title: {b.Title}");
                Console.WriteLine($"Author: {b.Author}");
                Console.WriteLine($"Year: {b.YearPublished}");
                Console.WriteLine();
            }
        }

        private void SearchBook()
        {
            Console.Write("Enter a title to search for: ");
            string search = Console.ReadLine();

            bool found = false;

            foreach (Book b in books)
            {
                if (b.Title.Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found: {b.Title} by {b.Author} ({b.YearPublished})");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
