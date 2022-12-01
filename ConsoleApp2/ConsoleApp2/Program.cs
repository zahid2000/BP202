using ConsoleApp2.Utilities.Exceptions;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //     seyhun:


            //         try
            //         {

            //             int a = int.Parse(Console.ReadLine());
            //             Console.WriteLine($"number={a}");
            //         }
            //catch (Exception exx)
            //{
            //             Console.WriteLine(exx.Message);

            //             goto seyhun;
            //} 
            #endregion
            try
            {
                int[] ints = { };
                string num = Console.ReadLine();
                AddToArr(ints, num);
            }
            
            catch(InvalidFormatException inex)
            {
                Console.WriteLine("Thanks Amil");
                int a = 1;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (Exception exx)
            {
                Console.WriteLine(exx.Message);
                int a = 1;
                int b = 0;
                Console.WriteLine(a / b);

            }
            finally
            {


                Console.WriteLine("Thanks!!");
            }



        }
        public static void AddToArr(int[] ints, string tempNum)
        {
            try
            {
                int num = int.Parse(tempNum);
                Array.Resize(ref ints, ints.Length + 1);
                ints[ints.Length - 1] = num;

            }
            catch (Exception exx)
            {

                throw new InvalidFormatException("Incorrect!");
            }

        }
    }

}