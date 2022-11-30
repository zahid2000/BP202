using System.Collections;

namespace Abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bus bus = new Bus();
            //bus.Id=5;
            string name = "Mahmud";
            Book book = new Book("Lotr", "Best seller");
            Library libraff = new Library(5);
            libraff[6] = book;

            Console.WriteLine(libraff[0].Name);

        }
    }
    public class Library:IEnumerable
    {
        private Book[] _books;
        public Library(int size)
        {
            _books = new Book[size];
        }
        public Book this[int index]
        {
            get
            {
                if (index < _books.Length)
                {
                    return _books[index];
                }
                throw new Exception();
            }
            set
            {
                if (index < _books.Length)
                {
                    _books[index] = value;
                    return;
                }
                throw new Exception("");
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
            
        }
    }
    public class Book
    {
        public Book(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Car
    {
        protected internal int Id { get; set; }
    }
  
}