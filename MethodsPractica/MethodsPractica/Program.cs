namespace MethodsPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    int count = SimpleMulti(num);
            //    Console.WriteLine(count);
            //}

            //int[] arr = { -2, 1, 3, -3, -4, -34, -12 };

            //foreach (int num in ChangeNegativeToPositive(arr))
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine(PrimeDvidedCount(100)); 

            int num=15;

            Console.WriteLine(ChangeNumber(out num)); 
            Console.WriteLine(num);
            int a = 16;

            //int[] arr = { 5 ,6,5,4};

            //Console.WriteLine(arr[0]);//5
            //Console.WriteLine(arr[0]);//15
            //Console.WriteLine(ChangeArr(arr)[0]); //15

        }


        static int ChangeNumber(out int number)
        {
            number = 0;
            return number;
        }
        static int[] ChangeArr(int[] numbers)
        {
            numbers[0] = 15;
            return numbers;
        }

        #region Change negative numbers to positive in array
        //static int[] ChangeNegativeToPositive(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < 0)
        //            arr[i] *= -1;
        //    }
        //    return arr;

        //} 
        #endregion


        #region int argument sade bolenlerinin sayini tapan method yazin
        //static int PrimeDvidedCount(int num)
        //{
        //    int count = 0;
        //    int dvidedNum = 2;
        //    while (num > 1)
        //    {
        //        if (num % dvidedNum == 0)
        //        {
        //            num = num / dvidedNum;
        //            count++;
        //            continue;
        //        }
        //        dvidedNum++;
        //    }
        //    return count;
        //} 
        #endregion


        #region Ilqarin kodu
        //static int SimpleMulti(int num)
        //{
        //    int count = 0;
        //    int i = 2;
        //    while (num > 1)
        //    {

        //        if (num % i == 0)
        //        {
        //            num /= i;
        //            count++;
        //            continue;
        //        }
        //        i++;

        //    }
        //    return count;
        //}
        #endregion

    }
}