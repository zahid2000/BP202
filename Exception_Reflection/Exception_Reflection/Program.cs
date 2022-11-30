using Exception_Reflection.Business.Abstracts;
using Exception_Reflection.Business.Concretes;
using Exception_Reflection.DataAccess.Concretes;
using Exception_Reflection.Models;

namespace Exception_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            //Person person1 = new Person { Id = 1, Name = "Eli", Surname = "Ibrahimov", Role = PersonRole.Dekan };
            //Person person2 = new Person { Id = 2, Name = "Eli", Surname = "Seyfullazade", Role = PersonRole.Muavin };
            //Person person3 = new Person { Id = 3, Name = "Nezrin", Surname = "Askerova", Role = PersonRole.Muellim };
            //Person person4 = new Person { Id = 4, Name = "Ilahe", Surname = "Letifova", Role = PersonRole.Rektor };
            //Person person5 = new Person { Id = 5, Name = "Ilqar", Surname = "Niftaliyev", Role = PersonRole.Muellim };
            //Person person6 = new Person { Id = 6, Name = "Gulgez", Surname = "Mammadova", Role = PersonRole.Muellim };

            //Person[] people = new Person[] { person1, person2, person3, person4, person5, person6 };

            //for (int i = 0; i < people.Length; i++)
            //{
            //    if (people[i].Role == PersonRole.Dekan)
            //    {
            //        Console.WriteLine(people[i].Name);
            //    }
            //} 
            #endregion


            #region Indexer

            //CustomString customString= new CustomString();
            //customString[0] = 's';
            //Console.WriteLine(customString[0]);
            #endregion

            #region Exceptions

            //try
            //{
            //    Console.WriteLine("Birinci ededi daxil et");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ikinci ededi daxil et");
            //    int num2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(num1 / num2);


            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("0 a bolme ola bilmez");
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Bu format dogru deyil");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);

            //    int[] arr = new int[2];
            //    arr[3] = 1;
            //}
            //finally
            //{
            //    Console.WriteLine("Hello Amil");
            //}
            //int[] arr = new int[3];
            //arr[4] = 1;
            //IndexOutOfRangeException




            //try
            //{
            //    string[] arr = new string[] { "Eli" };
            //    string name = Console.ReadLine();
            //    AddNameToArray(arr, name);
            //}
            //catch (InvalidNameException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //string[] arr = new string[] { "Eli" };
            //string name = Console.ReadLine();
            //bool result = AddNameToArray(arr, name);
            //if (result)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect format");
            //}
            #endregion
            Customer customer = new Customer { Id=1,Name="Amil"};
            ICustomerService customerService = new CustomerService(new CustomerManager());
            customerService.Add(customer);
         
        }
        public static bool AddNameToArray(string[] arr,string name)
        {
            Array.Resize(ref arr, arr.Length + 1);
            if (name[0] == Char.ToUpper(name[0]))
            {
                arr[arr.Length - 1] = name;
                return true;
            }
            throw new InvalidNameException("Ad formati dogru deyil");
        }
    }


   




    public interface ICalculator
    {
        int Sum(int a, int b);
        int Multiply(int a, int b);
    }
    public class Calculator : ICalculator
    {
        public int Sum(int a, int b)
        {
            return a +b;
        }
        public int Dvided(int a, int b)
        {
            return a / b;
        }
        private bool checkNum(int num)
        {
            return num > 0;
        }

        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }
    }


    public class MyCalculator : ICalculator
    {
        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

    #region Enum
    //enum PersonRole : byte
    //{
    //    Rektor, Prorektor, Muavin, Dekan, ZamDekan, Muellim
    //}

    //class Person
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public PersonRole Role { get; set; }
    //} 
    #endregion
}