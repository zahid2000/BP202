using File_Directory.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Xml2CSharp;

namespace File_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Multitasking
            //GetHttpClientAsync();
            //Console.ReadLine();
            //GetHttpClient(); 
            #endregion'

            #region File,Directory
            //string pathDr = @"C:\Users\lenovo\Desktop\Test\test1\test2";
            //string pathF = @"C:\Users\lenovo\Desktop\Test\test1\test2\hello.txt";
            //if (!Directory.Exists(pathDr))
            //{
            //    Directory.CreateDirectory(pathDr);
            //    Console.WriteLine("Folder Yarandi");
            //}
            //else
            //{
            //    Console.WriteLine("Artik movcuddur");

            //}
            //File.Create(pathF);
            //Directory.Delete(pathDr, true);


            //----------------------------------------------//
            //if (!File.Exists(pathF))
            //{
            //  FileStream file=  File.Create(pathF);
            //    Console.WriteLine("File Yarandi");

            //}
            //else
            //{
            //    Console.WriteLine("Artik movcuddur");
            //}
            //File.Delete(pathF);
            //using (StreamWriter streamWriter = new StreamWriter(pathF,true))
            //{
            //    streamWriter.WriteLine("Hello Amil",true);


            //}

            //using (StreamReader streamReader = new StreamReader(pathF))
            //{
            //    var result = streamReader.ReadToEnd();
            //    Console.WriteLine(result);
            //} 
            #endregion
            #region Serializer,Deserializer
            #region Json

            //Product product = new Product() { Id = 1,Name="BMW X6",Description="Fast",Price=30000 };
            //Product product1 = new Product() { Id = 2,Name="Prius",Description="20 kuza",Price=13000 };
            //Product product2 = new Product() { Id = 3,Name="VAZ 2107",Description="Super",Price=5000 };
            //Product product3 = new Product() { Id = 4,Name="Mustang Shelby",Description="67 Year",Price=60000 };
            //Product product4 = new Product() { Id = 5,Name="Mercedes Vyana",Description="Vito",Price=28000 };

            //OrderItem orderItem1 = new OrderItem() {Id=1,Product=product,Count=2,TotalPice= 60000};
            //OrderItem orderItem2 = new OrderItem() {Id=2,Product=product1,Count=1,TotalPice= 13000};
            //OrderItem orderItem3 = new OrderItem() {Id=3,Product=product2,Count=2,TotalPice= 10000};
            //OrderItem orderItem4 = new OrderItem() {Id=4,Product=product3,Count=3,TotalPice= 180000};
            //List<OrderItem> orderItems = new List<OrderItem> { orderItem1, orderItem2, orderItem3, orderItem4, };
            //Order order=new Order() { Id=1,OrderItems=orderItems,TotalPrice=263000};

            //JsonSerializer jsonSerializer=new JsonSerializer();
            //var JsonObject = JsonConvert.SerializeObject(order);
            ////Console.WriteLine(JsonObject);
            //using (StreamWriter sw=new StreamWriter(@"C:\Users\lenovo\Desktop\Code_Academy\BB202\File_Directory\File_Directory\Files\json1.json"))
            //{
            //    sw.Write(JsonObject);
            //}
            //string result;
            //using (StreamReader sr=new StreamReader(@"C:\Users\lenovo\Desktop\Code_Academy\BB202\File_Directory\File_Directory\Files\json1.json"))
            //{
            //     result = sr.ReadToEnd();
            //}

            //var order1 = JsonConvert.DeserializeObject<Order>(result);
            //foreach (var item in order1.OrderItems)
            //{
            //    Console.WriteLine(item.Product.Name);
            //}
            #endregion
            #region MyRegion
            //string xmlResult;


            //using (StreamReader sr=new StreamReader(@"C:\Users\lenovo\Desktop\Code_Academy\BB202\File_Directory\File_Directory\Files\XMLFile1.xml"))
            //{
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));
            //    ValCurs XmlObject = (ValCurs)xmlSerializer.Deserialize(sr);
            //    Console.WriteLine(XmlObject.ValType[0].Valute[0].Name);
            //}
            #endregion
            #endregion
            File.Create(@"C:\Users\lenovo\Desktop\Hello.txt");

            Program program =new Program();
            Program.Eli()

            
       

        }
      public static string Eli()
        {
            return "";
        }
        //public int Eli { get; set; }
        public int ID { get; set; }


        #region MultiTasking
        //    static async void GetHttpClientAsync()
        //    {
        //        HttpClient client = new HttpClient();
        //        Stopwatch stopwatch = new Stopwatch();
        //        List<Task<string>> tasks= new List<Task<string>>();
        //        stopwatch.Start();
        //        foreach (var url in GetUrls())
        //        {
        //            tasks.Add(client.GetStringAsync(url));
        //        }
        //           string[]   srt=await Task.WhenAll(tasks);
        //        stopwatch.Stop();
        //        Console.WriteLine($"Asynchronous -> {stopwatch.ElapsedMilliseconds} ms");
        //    }
        //    static void GetHttpClient()
        //    {
        //        HttpClient client = new HttpClient();
        //        Stopwatch stopwatch= new Stopwatch();
        //        stopwatch.Start();
        //        foreach (var url in GetUrls())
        //        {
        //            var result = client.GetStringAsync(url).Result;

        //        }
        //        stopwatch.Stop();
        //        Console.WriteLine($"Synchronous -> {stopwatch.ElapsedMilliseconds} ms");
        //    }
        //    static string[] GetUrls()
        //    {
        //        var urls = new string[]
        //        {
        //            "https://docs.microsoft.com",
        //"https://docs.microsoft.com/aspnet/core",
        //"https://docs.microsoft.com/azure",
        //"https://docs.microsoft.com/azure/devops",
        //"https://docs.microsoft.com/dotnet",
        //"https://docs.microsoft.com/dynamics365",
        //"https://docs.microsoft.com/education",
        //"https://docs.microsoft.com/enterprise-mobility-security",
        //"https://docs.microsoft.com/gaming",
        //"https://docs.microsoft.com/graph",
        //"https://docs.microsoft.com/microsoft-365",
        //"https://docs.microsoft.com/office",
        //"https://docs.microsoft.com/powershell"

        //        };
        //        return urls;
        //    } 
        #endregion
    }


    class Ilqar
    {
        public Ilqar()
        {

        }
        public int ID { get; set; }
        public static string Name { get; set; }
    }
}