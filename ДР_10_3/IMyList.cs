using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_10_3
{
    internal interface IMyList<T>
    {
        void Add(T item);

        T this[int index] { get; }

        int Count { get; }

        public bool Contains(T item);
    }
}
