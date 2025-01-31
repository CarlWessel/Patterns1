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
 * Purpose: interface to for creating an iterator to taverse list
 */

namespace Assi1.Aggregates
{
    interface Aggregate
    {
        IIterator CreateIterator();
    }
}
