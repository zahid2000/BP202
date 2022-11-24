
namespace AccessModifier
{
    internal class Program
    {
        //
        static void Main(string[] args)
        {
            //Public ve Internal -> class,all class member
            //private ve protected -> all class member

            //---------------------------------



            Car car = new();
            //car.Brand = "BMW";
            Console.WriteLine(car.Surname); 

        }
    }
    class BB
    {
        public int x;
    }
}