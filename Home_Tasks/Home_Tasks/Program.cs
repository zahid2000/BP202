namespace Home_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Salary=12};
            Customer customer1 = new Customer { Salary=232};
            Customer custome2 = new Customer { Salary=320};
            Customer customer3 = new Customer { Salary=2};

            Customer[] customers = {customer,customer1,custome2,customer3};
            Array.Sort(customers);

            
        }
    }
}