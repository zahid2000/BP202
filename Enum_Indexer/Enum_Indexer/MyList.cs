using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Indexer
{
    public class MyList
    {
        private int[] _arr = new int[0];
        public void Add(int num)
        {
            Array.Resize(ref arr, arr.Length+1);
            _arr[_arr.Length-1] = num;
        }

        public int this[int index]
        {
            get { return _arr[index]; }
        }
        public void Update(int num,int index)
        {
            if (index<_arr.Length &&index>0)
            {
                _arr[index] = num;

            }
            throw new Exception();
        }
    }
}
