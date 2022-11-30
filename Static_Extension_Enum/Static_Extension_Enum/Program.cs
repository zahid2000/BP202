namespace Static_Extension_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static
            //  Console.WriteLine(Calc.Id);
            //Calc calc1=new Calc();
            //  Console.WriteLine($"Id : {Calc.Id} Count : {Calc.count}");
            //Calc calc2=new Calc();
            //  Console.WriteLine($"Id : {Calc.Id} Count : {Calc.count}");

            //  Calc calc3 =new Calc();
            //  Console.WriteLine($"Id : {Calc.Id} Count : {Calc.count}");

            //  Calc calc4 =new Calc();

            //  Console.WriteLine($"Id : {Calc.Id} Count : {Calc.count}");


            #endregion
            //string Gmail = "Eli@gmail.com";
            //Console.WriteLine(a.CheckEmailFormat(4)); ;
            //int num = 5;
            //Calc calc = new Calc();
            //Console.WriteLine(calc.Pow(5));
            //int a;
            
            //Car model= new Car();
            //Car b ;
            //b.CarName= "Eli dersini yaxsi oxu";


            //b= new Car();
            //b.CarName= aaaa;
            //b.GetName();

            Showinfo(1);

        }
        static void Showinfo(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("bele melumat yoxdu");
                return;
            }
            Console.WriteLine("Melumat gonderildi");
        }
        void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }

      
    }
    struct Car:Bus
    {
        public string CarName;
        public string Name { get; set; }
        public string Color { get; set; }
        public void GetName()
        {
            Console.WriteLine(Name);
        }
        
    }
    interface Bus 
    {

    }
}