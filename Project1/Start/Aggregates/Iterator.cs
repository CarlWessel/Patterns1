using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public interface Iterator
    {
        object First();
        object GetPreviousItem();
        void Next();
        bool IsDone();
        object CurrentItem();

    }
}
