using System.Text;

namespace Delegate
{
    internal class Program
    {

        delegate bool Check(int num);
        delegate void Write<T,U>(T str, U str1);
        delegate R Calc<in T,in U,out R>(T n1,T n2);
        static void Main(string[] args)
        {
            #region Delegate
            //int[] arr = new int[] { 1, -3, 12, 15, 11 };
            //Console.WriteLine($"Tək --> {Sum(arr, SumOdd)}");
            //Console.WriteLine($"Cəm --> {Sum(arr, SumEven)}");
            //Console.WriteLine($"Positve --> {Sum(arr, SumPositive)}");
            //Console.WriteLine($"Negative --> {Sum(arr, SumNegative)}");
            //Write write1 = new Write(PrintName);
            //Write write = PrintFirstChars;
            //write += PrintName;
            //write += PrintLength;
            //write("Gulgez", "Memmedova");

            //Console.WriteLine("Artiq ikisiini cap et");
            //Write write1 = PrintName;
            //write1 += PrintLength;
            //write1("Gulgez", "Memmedova"); 
            #endregion

            #region Anonymous function,Arrow function
            //write += delegate (string str1, string str2)
            //{
            //    Console.WriteLine(str1[str1.Length - 1].ToString() + str2[str2.Length - 1].ToString());
            //};
            //  write += (str1, str2) =>
            //  {
            //      Console.WriteLine(str1[str1.Length - 1].ToString() + str2[str2.Length - 1].ToString());
            //  };
            //write("Murad", "Haci");


            //write-= delegate (string str1, string str2)
            //{
            //    Console.WriteLine(str1[str1.Length - 1].ToString() + str2[str2.Length - 1].ToString());
            //}; 
            //write("Murad", "Haci");

            //Check check = SumOdd;
            //check += SumEven;n
            //check += SumPositive;
            //Console.WriteLine(check(12)); 
            #endregion

            //Action<string, string> write = PrintFirstChars;
            //write += PrintLength;
            //write("Ali", "Ibra");
            //Action action = () => Console.WriteLine("Hello");



            //Calc<double,double,double> calc = SumDouble;
            ////calc.Invoke(5,12.1);
            ////calc(4, 5.3d);
            //Console.WriteLine(calc.Invoke(5, 12.1));
            //Func<double, double, double> func = (n1, n2) =>
            //{
            //    return n1 + n2;
            //};
            Predicate<int> predicate = (n) => n % 2 == 0;


            List<int> list = new List<int>() { 1,2,3,4,5,11,12,13,14};
            List < int > list1= list.FindAll(n => n % 2 != 0);
            list1.ForEach(delegate (int n)
            {
                Console.WriteLine(n);
            });
            list1.ForEach(n => Console.WriteLine(n));
            


        }
        static double SumDouble(double n1,double n2)
        {
            return n1 + n2;
        }

        static void PrintName(string name,string surname)
        {
            Console.WriteLine(name + " " + surname); 
        }
        static void PrintLength(string name, string surname)
        {
            Console.WriteLine(name.Length + surname.Length);
        }
        static void PrintFirstChars(string name, string surname)
        {
            Console.WriteLine(name[0].ToString() + surname[0].ToString());
        }

        //static int Sum(int[] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item%2!=0)
        //            result += item;
        //    }
        //    return result;
        //}
        static bool Num()
        {
            return true;
        }
        static int Sum(int[] arr, Check func)
        {
            int result = 0;
            foreach (var item in arr)
            {
                if (func(item))
                    result += item;
            }
            return result;
        }
        static bool SumOdd(int num)
        {
            Console.WriteLine(num % 2 != 0);
            return num % 2 != 0;
        }
        static bool SumEven(int num)
        {
            Console.WriteLine(num % 2 == 0);

            return num % 2 == 0;
        }
        static bool SumPositive(int num)
        {
            Console.WriteLine(num > 0);

            return num  > 0;
        }
        static bool SumNegative(int num)
        {
            return num < 0;
        }
        //static int SumEven(int[] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //            result += item;
        //    }
        //    return result;
        //}

        //static int SumPositiven(int[] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 > 0)
        //            result += item;
        //    }
        //    return result;
        //}

    }
}