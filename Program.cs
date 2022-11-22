using Class;

namespace Containss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1,"Random",10,5,"drama");
            Book book2 = new Book(2, "Green Mile", 13, 3, "drama");
            Book book3 = new Book(3, "FM Book", 20, 6, "science");
            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            Book[] filteredBooks = library.GetFilteredBooks("drama");
            foreach (var item in filteredBooks)
            {
                Console.WriteLine(item.name);
            }
            Book[] getfilteredBooks = library.GetFilteredBooks(5,15);
            foreach (var item in getfilteredBooks)
            {
                Console.WriteLine(item.Price);
            }
        }
        
    }
    
}
