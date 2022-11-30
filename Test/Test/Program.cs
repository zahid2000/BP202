using Test.Models;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task
            /*Product Classıməz var id name price si var
                ProductDatabase clasımız var ProuctDatabase clasının ProductArray-i var maksimum 
                olçusu 5 dir
                consoldan add product dediyimiz zaman bizdən id sini name price - ni teleb etsin
                valid dəyər olacaqı təqdirdə Array - ə əlavə edin
                valid(daxil olunan dəyərlər boş olmamalıdır)
                Əgər array da artıq 5 product vardırsa database doldu mesaj çıxarsın
                ProductDatabase daxilində SearchProduct deyə method - u olsun
                    method string -dən parametr qebul etsin namə-yə görə array-dəki
                productarı axtarsın vardısa consola çıxarsın yoxdursa nəticə tapılmadı çıxsın*/
            //ProductDb productDb = new ProductDb();
            //while (true)
            //{
            //    Console.WriteLine("1-add product");
            //    Console.WriteLine("0-close product");
            //    int value = int.Parse(Console.ReadLine());

            //    if (value == 1)
            //    {
            //        addProduct(productDb);
            //        productDb.SearchProduct("amil");
            //    }

            //}
            //string name = "Zahid";
            //string name1 = "Zahid";
            //Console.WriteLine(name1);
            //name1 = "Eli";
            //Console.WriteLine(name);
            //Console.WriteLine(name1);

            //String name2 = new String("Zahid");
            //String name3 = name2;
            //name3 = "Murad";
            //Console.WriteLine(name2);
            //Console.WriteLine(name3); 
            #endregion
            foreach (var item in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(item);

            }
            MyStruct  myStruct= new MyStruct(5);
        }
        enum WeekDays : int
        {
            Monday = 1, Tuesday = 2, Wednesday = 3, Saturday = 4, Friday = 5, Thursday = 6, Sunday = 7

        }

        struct MyStruct
        {
            public MyStruct()
            {
                Console.WriteLine("Hello world");
            }
            public MyStruct(int a)
            {
                Console.WriteLine(a);
            }
        }

        public static void addProduct(ProductDb productDb)
    {
        Console.WriteLine("enter id: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("enter name: ");
        string name = Console.ReadLine().Trim();

        Product product = new Product();
        product.id = id;
        product.name = name;

        if (id > 0 && !String.IsNullOrEmpty(name))
        {
            productDb.AddProduct(product);
        }
        else
        {
            Console.WriteLine("invalid Name or Id");
        }


    }
}
}