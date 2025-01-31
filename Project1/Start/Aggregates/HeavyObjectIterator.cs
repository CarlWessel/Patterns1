using System;
using System.Collections.Generic;
using System.Text;

/*
 * Group memebers:
 *  Carl
 *  Cody
 *  Trish
 *  Ethan
 *  
 *  Purpose: Implements iterator class to iterate through a heavyobjectlist
 */

namespace Assi1.Aggregates
{
    class HeavyObjectIterator : IIterator
    {
        private HeavyObjectList aggregate;
        private int current = 0;

        public HeavyObjectIterator(HeavyObjectList aggregate)
        {
            this.aggregate = aggregate;
        }

        public HeavyObject CurrentItem()
        {
            return this.aggregate.At(current);
        }

        public HeavyObject First()
        {
            current = 0;
            return CurrentItem();
        }

        public HeavyObject GetPreviousItem()
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

