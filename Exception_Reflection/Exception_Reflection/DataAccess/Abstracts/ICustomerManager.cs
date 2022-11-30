using Exception_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Reflection.DataAccess.Abstracts
{
    public interface ICustomerManager
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
        Customer Get(int id);
    }
}
