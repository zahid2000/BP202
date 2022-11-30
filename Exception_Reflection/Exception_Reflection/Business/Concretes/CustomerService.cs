using Exception_Reflection.Business.Abstracts;
using Exception_Reflection.DataAccess.Abstracts;
using Exception_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Reflection.Business.Concretes
{
    public class CustomerService : ICustomerService
    {
        private ICustomerManager _customerManager;
        public CustomerService(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }


        public void Add(Customer customer)
        {
            if (customer.Name.Length>2)
            {
                _customerManager.Add(customer);
            }
        }

        public void Delete(Customer customer)
        {
           
            if (IsExists(customer.Id))
            {
                _customerManager.Delete(customer);
            }
            throw new Exception("Tapilmadi");
        }

        public Customer Get(int id)
        {
            if (id>0)
            {
                return _customerManager.Get(id);

            }
            throw new Exception("Tapilmadi");
        }

        public void Update(Customer customer)
        {
            if (IsExists(customer.Id))
            {
                if (customer.Name.Length>2)
                {
                    _customerManager.Update(customer);
                }
                throw new Exception("Ad dogru deyil");
            }
            throw new Exception("Bu adam bazada yoxdu");
        }


        private bool IsExists(int id)
        {
            var result = Get(id);
            if (result != null)
            {
                return true;
            }
            return false;
        }

    }
}
