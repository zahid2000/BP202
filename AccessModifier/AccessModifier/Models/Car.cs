namespace AccessModifier
{
    class Car
    {
        public Car()
        {
            Brand = "Mercedes";
        }
        public int Surname { get; set; }
        private int _age;
        private int Age;
        protected string Name;
        public readonly string Brand="BMW";
        public int DateYear;
        private int _fuel;
        //public int Fuel {
        //    get
        //    {
        //        if (_fuel > 0)
        //        {
        //            return _fuel;
        //        }
        //        return -1;
        //    }
        //    set {
        //        if (value>0)
        //        {
        //            _fuel = value;
        //            return;
        //        }
        //        Console.WriteLine("Duzgun miqdar daxil et");
        //    } 
        //}
        public int Engine { get; } = 15;
        private void Run()
        {
            Name = "Eli";
            Age = 10;
        }
        
        //public void SetFuel(int fuel)
        //{
        //    if (fuel>0)
        //    {
        //        _fuel = fuel;
        //        return;
        //    }
        //    Console.WriteLine("Duzgun miqdar daxil et");
        //}

        //public int GetFuel()
        //{
        //    if (_fuel>0)
        //    {
        //        return _fuel;
        //    }
        //    return -1;
        //}

    }

    class Bus:Car
    {
        public int PassengerCount;

        public void Set()
        {
            Name = "Eli";
        }
    }
}
