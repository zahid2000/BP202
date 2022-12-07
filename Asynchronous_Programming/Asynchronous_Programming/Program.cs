using System;
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
            //Test test = new Test();
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

            #region XmlSerialization
            //XmlSerializer xmlSerializer=new XmlSerializer(typeof(ValCurs));
            //using (StreamReader sr=new StreamReader(@"C:\Users\lenovo\Desktop\Code_Academy\BB202\Asynchronous_Programming\Asynchronous_Programming\XMLFile1.xml"))
            //{
            //    ValCurs result = (ValCurs)xmlSerializer.Deserialize(sr);
            //    foreach (var valType in result.ValType)
            //    {
            //        foreach (var valute in valType.Valute)
            //        {
            //            Console.WriteLine($"{valute.Name} -> {valute.Value}");
            //        }
            //    }
            //} 
            #endregion
            GetHttpContentAsync();
            Console.ReadLine();
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

        #region Task,Asyn,Await
        //public static void Go()
        //{
        //    GoAsync();
        //    Console.ReadLine();
        //}
        //public static async void GoAsync()
        //{
        //    Stopwatch stopwatch=new Stopwatch();    
        //    Console.WriteLine("Starting");
        //    stopwatch.Start();
        //    var task1 = Sleep(5000);
        //    var task2 = Sleep(3000);

        //    int[] result = await Task.WhenAll(task1, task2);
        //    stopwatch.Stop();

        //    Console.WriteLine($"Slept for a total of  {stopwatch.ElapsedMilliseconds} ms");


        //}

        //private async static Task<int> Sleep(int ms)
        //{
        //    Console.WriteLine("Sleeping for {0} at {1}", ms, Environment.TickCount);
        //    await Task.Delay(ms);
        //    Console.WriteLine("Sleeping for {0} finished at {1}", ms, Environment.TickCount);
        //    return ms;
        //}
        //static async void Get()
        //{
        //    int a =await GetAsync();
        //    int b =await GetAsync();
        //}
        //static async Task<int> GetAsync()
        //{
        //    return 100;
        //} 
        #endregion

        static async Task GetHttpContentAsync()
        {
            Stopwatch stopwatch = new Stopwatch();
            var client = new HttpClient();
            List<Task<string>> results= new List<Task<string>>();
            stopwatch.Start();
            foreach (var url in GetUrls())  
            {
                 results.Add(client.GetStringAsync(url));
            }
            await Task.WhenAll(results);
            stopwatch.Stop();
            Console.WriteLine($"ASynchronous ->{stopwatch.ElapsedMilliseconds} ms");
        }
        static async void GetHttpContent()
        {
            Stopwatch stopwatch=new Stopwatch();
            var client=new HttpClient();
            stopwatch.Start();
            foreach (var url in GetUrls())
            {
                var result =  client.GetStringAsync(url).Result;
                Console.WriteLine($"{url} -> {result.Length}");
            }
            stopwatch.Stop();
            Console.WriteLine($"Synchronous ->{stopwatch.ElapsedMilliseconds} ms");
        }
        static string[] GetUrls()
        {
            string[] urls = {"https://docs.microsoft.com",
    "https://docs.microsoft.com/aspnet/core",
    "https://docs.microsoft.com/azure",
    "https://docs.microsoft.com/azure/devops",
    "https://docs.microsoft.com/dotnet",
    "https://docs.microsoft.com/dynamics365",
    "https://docs.microsoft.com/education",
    "https://docs.microsoft.com/enterprise-mobility-security",
    "https://docs.microsoft.com/gaming",
    "https://docs.microsoft.com/graph",
    "https://docs.microsoft.com/microsoft-365",
    "https://docs.microsoft.com/office",
    "https://docs.microsoft.com/powershell"
};
            return urls;
        }

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
    //            lock (obj)//H
    //            {
    //                lock(obj1)
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
    //            lock (obj1)//E
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