using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public class HeavyObjectList : Aggregate
    {
        protected List<object> container = new List<object>();

        public Iterator CreateIterator()
        {
            return new HeavyObjectIterator(this);
        }

        public void Add(object item)
        {
            container.Add(item);
        }

        public object At(int position)
        {
            return container[position];
        }

        public int Length()
        {
            return container.Count;
        }

        public void Print()
        {
            foreach (var item in container)
            {
                if (item is HeavyObject heavyObj)
                {
                    heavyObj.Print();
                }
                else
                {
                    Console.WriteLine(item?.ToString());
                }
            }
        }
    }

}
