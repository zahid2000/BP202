
namespace Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sparrow sparrow=new Sparrow();
            //sparrow.Grow();
            
            //Monkey monkey = new Monkey();
            //monkey.Sound();
            //monkey.Grow();

            //Animal dog=new Dog();
            //dog.Grow();
            //Animal shark = new Shark();
            //shark.Grow();
            //Dog dog = new Dog();    
            //dog.Sound();
            //dog.Grow();

            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Sum(5, 6)); 
            Customer customer= new Customer();
            customer.Name = "Elmurad";
            ICustomerManager customerManager = new CustomerManagerSql();
            ICustomerManager customerManagerOracle =new CustomerManagerOrcle();


            CustomerService customerService = new CustomerService(customerManagerOracle);
            customerService.Add(customer);


        }

    }
}