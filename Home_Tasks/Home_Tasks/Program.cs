using System.Numerics;

namespace Home_Tasks
{
    internal class Program
    {
        delegate bool Check(int num);
        delegate  int Eli();
        delegate List<T> Eli2<T>(int[] arr,List<T> list);

        static void Main(string[] args)
        {
            #region Last
            //Customer customer = new Customer { Salary=12};
            //Customer customer1 = new Customer { Salary=232};
            //Customer custome2 = new Customer { Salary=320};
            //Customer customer3 = new Customer { Salary=2};

            //Customer[] customers = {customer,customer1,custome2,customer3};
            //Array.Sort(customers); 
            #endregion
            //List<int> numbers = new List<int> { 1, -2, 3, -4, 5, -6, 7, };
            //Console.WriteLine(GetSum(numbers, (x) => x % 2 == 0));
            //Console.WriteLine(GetSum(numbers, delegate (int x)
            //{
            //    return x % 2 == 0 && x > 0;
            //}));
            //Eli eli = GetNum;

            //Eli2<Customer> eli2 =Program<Customer>.GetCustomer;
            //Eli2<int> eli22 = GetCustomer1;
            //Eli2<Customer> Sima = Product<Customer>.GetSum ;
            //Sima(new int[] { 1,2},new List<Customer>());
         
        }

        


        //static int GetNum()
        //{

        //}

        //static List<T> GetCustomer(int[] arr,List<Customer> list)
        //{
        //    return null;
        //}
        //static List<T> GetCustomer1(int[] arr, List<Customer> list)
        //{
        //    return null;
        //}
        static int GetSum(List<int> list,Check check)
        {
            int result = 0;
            list.ForEach((x) => {
                if (check(x))
                {
                    result += x;
                }

            }

            );
            return result;

        }
       public bool GetPositiveSum(int n)
        {
            return n>0;
        }
        public bool GetNegativeSum(int n)
        {
            return n < 0;
        }

    }

    class Product<T>
    {
      public  static List<T> GetSum(int[] arr, List<T> values)
        {
            return new List<T>();
        }
    }
    
}