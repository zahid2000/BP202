namespace Enum_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Enum
            ////School school= new School();
            ////if (school.Name==(int)SchoolType.Secondary)
            ////{
            ////    Console.WriteLine("Usaginiz burda oxuya biler");
            ////}
            ////else if (school.Name.Equals(SchoolType.Secondary))
            ////{
            ////    Console.WriteLine("Usaginiz burda oxuya biler");

            ////}
            ////int a = 100;
            ////if (a==(int)SchoolType.High)
            ////{
            ////    Console.WriteLine("Dogrudur");
            ////}
            ////if (200==ActivityStatusCode.success)
            ////{
            ////        100-information
            ////        200-success 
            ////        201-created 
            ////        404-Not found
            ////        500-Interna server
            ////}

            ////foreach (var item in )
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(Enum.GetName(typeof(SchoolType), 15)); 
            #endregion
            //string name = "Eli";
            //name[1] = 'a';
            //Console.WriteLine(name[1]);
            //Book book = new Book { Name = "Sefiller", Description = "Best Seller" };
            //Library libraff = new Library(5);
            ////libraff.Books[0]=book;
            //libraff[0] = book;
            //Console.WriteLine(libraff[0].Name);

            MyList myList= new MyList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            Console.WriteLine(myList[7]);
        }
    }
    //List Clasiniz var.Add methodu vasitesile class daxilindeki int arrayina deyer elave ede bilirem ve List[0] hemin arrayin 0-ci indeksdeki deyerin i get ede bilerem.Amaaaaa --> list[3]=5 ede bilmerem <--
    public class Library
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
                if (index < _books.Length && index >= 0)
                {
                    return _books[index];
                }
                throw new Exception("Out of range");
            }
        }
    }
    public class Book
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }




    #region Enum
    //enum SchoolType:byte
    // {
    //    Primary=10,Secondary=15,High=100 ,University=23,Master=110,Doctorantura=99
    // }

    // public class School
    // {
    //     int id;
    //     public int Name = 0;
    // } 
    #endregion
}