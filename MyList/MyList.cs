using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
    {
        private T[] list;

        public MyList() => list = new T[0];

        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public void Add(T value)
        {
            Array.Resize(ref list, Count + 1);
            list[Count - 1] = value;
        }

        public int Count => list.Length; 
    }
}
