using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public interface IIterator
    {
        HeavyObject First();
        HeavyObject GetPreviousItem();
        void Next();
        bool IsDone();
        HeavyObject CurrentItem();

    }
}
