namespace Abstract_Interface
{
    class CustomerService
    {
        private ICustomerManager _customerManager;
        public CustomerService(ICustomerManager customerManager)
        {
            _customerManager= customerManager;
        }

        public void Add(Customer customer)
        {
            if (customer!=null)
            {
                if (customer.Name.Length>2)
                {

                }
                _customerManager.AddCustomer(customer);
            }
        }

    }



}
