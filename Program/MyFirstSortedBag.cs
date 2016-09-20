using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   public class MyFirstSortedBag : ISortedBag
    {

        private List<int> sortedList = new List<int>();

       public int Size => sortedList.Count;

       public int Pop()
       {
           int value = sortedList[0];
       }

       public int IList()
       {
           throw new NotImplementedException();
       }

       public void Add(int v)
        {
            sortedList.Add(v);
            
        }

        
    }
}
