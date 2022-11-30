using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Reflection
{
    internal class CustomString
    {
        private char[] _arr=new char[0];

       public char this[int index] { get { return _arr[index]; } set {

                Array.Resize(ref _arr, _arr.Length + 1);
                    

             _arr[index] = value;
            } }
    }
}
