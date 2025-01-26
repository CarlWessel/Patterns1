using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public class HeavyObjectIterator : Iterator
    {
        protected HeavyObjectList aggregate;
        protected int current = 0;

        public HeavyObjectIterator(HeavyObjectList aggregate)
        {
            this.aggregate = aggregate;
        }

        public object CurrentItem()
        {
            if (current >= 0 && current < aggregate.Length())
            {
                return aggregate.At(current);
            }
            throw new InvalidOperationException("Iterator is out of bounds.");
        }

        public object First()
        {
            current = 0;
            return CurrentItem();
        }

        public object GetPreviousItem()
        {
            if (current > 0)
            {
                current--;
                return CurrentItem();
            }
            throw new InvalidOperationException("No previous item.");
        }

        public bool IsDone()
        {
            return current >= aggregate.Length();
        }

        public void Next()
        {
            if (!IsDone())
            {
                current++;
            }
        }
    }
}

