using System.Collections;

namespace Home_Tasks
{

    public class Customer:IComparable<Customer>
    {
        public int Salary { get; set; }

        public int CompareTo(Customer? other)
        {
            return Salary.CompareTo(other.Salary);
        }
    }
}
