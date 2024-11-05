using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashna_4
{
    internal class Library
    {
        ArrayList books = new ArrayList();


        public void AddBook(string title, string author)
        {
            Book newBook = new Book(title, author);
            books.Add(newBook);
            Console.WriteLine("Knigata e uspeshno dobavena.");
        }

        
       
        
            public void RemoveBook(string title)
            {
                Book bookToRemove = null;
                foreach (Book book in books)
                {
                    if (book.Title.ToLower() == title.ToLower())
                    {
                        bookToRemove = book;
                        break;
                    }
                }

                if (bookToRemove != null)
                {
                    books.Remove(bookToRemove);
                    Console.WriteLine("Knigata beshe uspeshno premahnata.");
                }
                else
                {
                    Console.WriteLine("Kniga s tova zaglavie ne beshe namerena.");
                }
            }



        public void SearchBook(string title)
        {
            Book foundBook = null;
            foreach (Book book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    foundBook = book;
                    break;
                }
            }

            if (foundBook != null)
            {
                Console.WriteLine("Namerena kniga:");
                Console.WriteLine(foundBook);
            }
            else
            {
                Console.WriteLine("Kniga s tova zaglavie ne beshe namerena.");
            }
        }


        public void ListAllBooks()
        {
            if (books.Count > 0)
            {
                Console.WriteLine("Knigi v bibliotekata:");
                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("Bibliotekata e prazna.");
            }
        }
    }

}

