namespace UpCasting_DownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Custing

            #region Upcasting,Boxing,Implicit
            //Shark shark=new Shark();
            //shark.Length = 5;
            //Console.WriteLine(shark.Length); ;

            //Fish fish = new Shark();
            //Fish fish1 = new Sazan();
            //Fish[] fishes = { fish, fish1};
            //Animal animal = fish; 
            //Object animalObj =animal;
            //Console.WriteLine(animalObj.GetType().Name);



            //Console.WriteLine(fish.GetType().Name);
            #endregion
            #endregion
            #region DownCasting,UnBoxing,Explicit
         

            Animal fish = new Shark { Length=5};
            Animal fish1 = new Sazan();
            Animal parrot=new Parrot();

            //Shark shark = fish as Shark;
            //Shark shark = (Shark)fish;

            Animal[] animals = { parrot,fish, fish1 };
            foreach (var animal in animals)
            {
                if (animal is Parrot p)
                {
                   
                    p.Fly();
                }
                else if (animal is Sazan s)
                {
                    s.Swim();
                }
                else if(animal is Shark sh)
                {
                    Console.WriteLine(sh.Length); ;
                }
            }



            #endregion
        }
    }
    #region Custing

        #region Upcasting,Boxing,Implicit
    abstract class Animal
    {
        public abstract void Eat();
    }
    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Parrot : Bird
    {
        public int CountOfWing { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Parrot eating");
        }

        public override void Fly()
        {
            Console.WriteLine("Parrot flying");

        }
    }


    abstract class Fish:Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish
    {
        public int Length { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating");

        }

        public override void Swim()
        {
            Console.WriteLine("Shark swimming");

        }
    }

    class Sazan : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Sazan eating");

        }

        public override void Swim()
        {
            Console.WriteLine("Sazan swimming");

        }
    }
    #endregion
    #endregion
}