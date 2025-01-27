using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    interface Iterator
    {
        HeavyObject First();
        HeavyObject GetPreviousItem();
        void Next();
        bool IsDone();
        HeavyObject CurrentItem();

    }
}
