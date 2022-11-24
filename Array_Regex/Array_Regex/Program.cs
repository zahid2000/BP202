using System.Text.RegularExpressions;

namespace Array_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mail = "Zahid123422134.mam4132413413dov07@gmail.com";

            bool result = Regex.IsMatch(mail, @"^([a-zA-Z0-9]+([\._\-]{1})?){1,}[\w]\@{1}([a-zA-Z]+([\.]{1})?){1,}([a-zA-Z])\.[a-zA-Z]+$"); 
            Console.WriteLine(result);

           string[] arr= Regex.Split(mail, @"\d");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //int[] nums = { -1,3,1,2,-34};
            //Array.Sort(nums);
            //Array.Reverse(nums);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(nums.Rank); 
            //Array.Resize(ref nums,3);

            //Resize(ref nums,5);
            //Resize(ref nums,5);
            //void Resize(ref int[] nums,int length)
            //{
            //    int[] arr=new int[length];
            //    nums = arr;
            //}
        }
    }
}