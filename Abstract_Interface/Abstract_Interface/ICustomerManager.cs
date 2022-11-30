using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    //public interface ISum
    //{
    //    public int Name { get; set; }
    //    public  int Sum(int a, int b)
    //    {
    //        return a+ b;
    //    }
    //    public int SumArr(int[] arr)
    //    {

    //    }
    //}
    //public interface IDifference
    //{
    //    int Difference(int a, int b);   
    //}
    //public abstract class BaseCalc
    //{
    //    public abstract int Sum(int x, int y);
    //    public abstract int Difference(int x, int y);
    //    public abstract int Dvided(int x, int y);
    //    public abstract int Multiply(int x, int y);
    //}
    //public  class Calculator
    //{
    //    public int Sum(int a,int b) {
    //        return a + b;
    //    }

    //    public int Difference(int a, int b)
    //    {
    //        return a - b;
    //    }

    //    public int Dvided(int a, int b)
    //    {
    //        return a / b;
    //    }

    //    public int Multiply(int a, int b)
    //    {
    //        return a *b;
    //    }
    //}

    //public class OfficeSale :BaseCalc, ISum, IDifference
    //{


    //    public int Difference(int a, int b)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Sum(int a, int b)
    //    {
    //        return a + b;
    //    }
    //}

    public interface ICustomerManager
    {
        string GetCustomerName();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);

    }



}
