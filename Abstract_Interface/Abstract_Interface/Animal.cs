using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    internal abstract class Animal
    {
        protected Animal()
        {

        }
        public virtual int Color { get; set; }
        public abstract void Sound();
        //public abstract string Walk(int num);
        public abstract void Eat();
        public virtual  void Grow()
        {
            Console.WriteLine("Animal is growing");
        }

    }

    abstract class Bird : Animal
    {
       public abstract void Fly();
        public sealed override void Grow()
        {
            Console.WriteLine("Grow as Bird");
        }
    }

    class Sparrow : Bird
    {
     

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Sparrow");
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }

        //public override void Grow()
        //{
        //    Console.WriteLine("Grow as Sparrow");
        //}
    }
    class Monkey : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as monkey");
        }

        public override void Sound()
        {
            Console.WriteLine("Sound as monkey");
        }
    }
   
    class Dog : Animal
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }
        public void Eat(string name)
        {

        }
        public override void Sound()
        {
            Console.WriteLine("Sound as Dog");

        }
        //public override  void Grow()
        //{
        //    Console.WriteLine("Grow as Dog");
        //}
    }
    class Shark : Animal
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }
    }

    //abstract class  Car
    //{
    //    public abstract void Run();
    //}

    //sealed class Bmw : Car
    //{
    //    public  override void Run()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
   
}
