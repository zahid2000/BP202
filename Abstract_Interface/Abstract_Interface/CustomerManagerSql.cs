namespace Abstract_Interface
{
    public class CustomerManagerSql : ICustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Add with Sql");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Musteri bazadan silindi");
        }

        public string GetCustomerName()
        {
            Console.WriteLine("Musteri Name");
            return"";
        }

        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine("Update Customer");
        }
    }

    public class CustomerManagerOrcle : ICustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Add with Oracle");
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public string GetCustomerName()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
