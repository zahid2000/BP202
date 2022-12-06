using System.Diagnostics;

namespace Asynchronous_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Thread
            //Thread thread = new Thread(Loop1);
            //Thread thread1 = new Thread(Loop2);
            //thread.Start();
            //thread1.Start();

            #endregion
            #region Race condition,DeadLock
            //Test test=new Test();
            //Thread thread1 = new Thread(test.Increment);
            //Thread thread2 = new Thread(test.Decrement);
            //thread1.Start();

            //thread2.Start();
            //thread2.Join();
            //thread1.Join();

            ////Sinchron
            ////test.Increment();
            ////test.Decrement();
            //Console.WriteLine(test.Count); 
            #endregion

            Go();
        }
        #region Thread
        //static void Loop1()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Thread.Sleep(1000);

        //        Console.WriteLine($"Loop1 -> {i}");
        //    }
        //}
        //static void Loop2()
        //{


        //    for (int i = 100; i < 200; i++)
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine($"Loop2 -> {i}");
        //    }
        //} 
        #endregion


        public static void Go()
        {
            GoAsync();
            Console.ReadLine();
        }
        public static async void GoAsync()
        {
            Stopwatch stopwatch=new Stopwatch();    
            Console.WriteLine("Starting");
            stopwatch.Start();
            var task1 = Sleep(5000);
            var task2 = Sleep(3000);
            stopwatch.Stop();

            int[] result = await Task.WhenAll(task1, task2);
            Console.WriteLine($"Slept for a total of  {stopwatch.ElapsedMilliseconds} ms");


        }

        private async static Task<int> Sleep(int ms)
        {
            Console.WriteLine("Sleeping for {0} at {1}", ms, Environment.TickCount);
            await Task.Delay(ms);
            Console.WriteLine("Sleeping for {0} finished at {1}", ms, Environment.TickCount);
            return ms;
        }
        //static async void Get()
        //{
        //    int a =await GetAsync();
        //    int b =await GetAsync();
        //}
        //static async Task<int> GetAsync()
        //{
        //    return 100;
        //}

    }
    #region Race condition,DeadLock
    //class Test
    //{
    //    public int Count { get; set; }
    //    public object obj = new object();
    //    public object obj1 = new object();
    //    public void Increment()
    //    {
    //        for (int i = 0; i < 100000; i++)
    //        {
    //            lock (obj)//Amil
    //            {
    //                lock (obj1)
    //                {
    //                    Count++;

    //                }

    //            }

    //        }
    //    }
    //    public void Decrement()
    //    {
    //        for (int i = 0; i < 100000; i++)
    //        {
    //            lock (obj1)//Murad
    //            {
    //                lock (obj)
    //                {
    //                    Count--;
    //                }
    //            }
    //        }
    //    }
    //} 
    #endregion
}