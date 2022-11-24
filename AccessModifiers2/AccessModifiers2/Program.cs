using System;
namespace AccessModifiers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AccessModifiers
            //  Car car = new Car();
            //  //car.title;
            //  //car.message;
            //  //Bus bus= new Bus();
            //  //bus.message
            //  car.id = 1;
            //  Console.WriteLine(car.id);

            //  Bus bus= new Bus();
            //Console.WriteLine("hello");
            //  Test1 test = new Test1(); 
            #endregion

            MailValidation validation = new MailValidation();
          bool result= validation.CheckEmailFormat("zahidmamedov07@gmail.com");
            Console.WriteLine(result);
        }
    }

}