using Exception_Reflection.DataAccess.Abstracts;
using Exception_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Reflection.DataAccess.Concretes
{
    public class Net6CustomerManager : ICustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Elave Edildi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Silindi");
        }

        public Customer Get(int id)
        {
            return new Customer { Id = 1, Name = "Ali" };
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Yenilemnmdi");
        }
    }
}
