using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_10_3
{
    internal class MyList<T> : IMyList<T>
    {
        private T[] array;
        private int count;

        public MyList()
        {
            array = new T[0];
            count = 0;
        }

        public int Count { get { return count; } }

        public T this[int index] { get { return array[index]; } }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                T[] newArray = new T[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            array[count++] = item;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

