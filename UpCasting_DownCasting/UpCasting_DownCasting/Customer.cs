using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCasting_DownCasting
{
    public class Customer
    {
        private static int _count;
        public Customer()
        {
            Id = _count;
            _count++;
        }

        public Customer(string name, int staj):this()
        {
            Name = name;
            Staj = staj;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Staj { get; set; }

        public static bool operator >(Customer c1,Customer c2)
        {
            return c1.Staj > c2.Staj;
        }
        public static bool operator <(Customer c1, Customer c2)
        {
            return c1.Staj < c2.Staj;
        }

        public static bool operator ==(Customer c1,Customer c2)
        {
            return c1.Staj == c2.Staj;
        }
        public static bool operator !=(Customer c1, Customer c2)
        {
            return c1.Staj != c2.Staj;
        }

    }
}
