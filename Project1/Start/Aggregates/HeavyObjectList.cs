using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    class HeavyObjectList : Aggregate
    {
        protected List<HeavyObject> container = new List<HeavyObject>();

        public Iterator CreateIterator()
        {
            return new HeavyObjectIterator(this);
        }

        public void Add(HeavyObject item)
        {
            container.Add(item);
        }

        public HeavyObject At(int position)
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
