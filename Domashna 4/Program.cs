namespace Domashna_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("Izberi opciq:");
                Console.WriteLine("1 - Dobavqne na kniga");
                Console.WriteLine("2 - Premahvane na kniga po zaglavie");
                Console.WriteLine("3 - Tyrsene na kniga po zaglavie");
                Console.WriteLine("4 - Izvejdane na vsichki knigi");
                Console.WriteLine("5 - Izhod");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Vavedi zaglavie na knigata: ");
                        string title = Console.ReadLine();
                        Console.Write("Vavedi avtor na knigata: ");
                        string author = Console.ReadLine();
                        library.AddBook(title, author);
                        break;

                    case "2":
                        Console.Write("Vavedete zaglavie na knigata, koqto iskate da premahnete: ");
                        title = Console.ReadLine();
                        library.RemoveBook(title);
                        break;

                    case "3":
                        Console.Write("Vavedete zaglavie za tyrsene: ");
                        title = Console.ReadLine();
                        library.SearchBook(title);
                        break;

                    case "4":
                        library.ListAllBooks();
                        break;

                    case "5":
                        Console.WriteLine("Izhod ot programata.");
                        break;

                       
                }
            }
        }
    }
 }

