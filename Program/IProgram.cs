using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    interface IProgram<T>
    {
        public ConcurrentBag<T> Bag;
        T Add(T t);
        void Remove(T t);
        T Get(T t);
    }
}
