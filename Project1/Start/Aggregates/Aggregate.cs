using System;
using System.Collections.Generic;
using System.Text;

/*
 * Group memebers:
 *  Carl Wessel
 *  Cody Sykes
 *  Trishia Salamangkit
 *  Ethan Reimer
 *  
 * Purpose: Interface for creating an iterator to traverse list
 */

namespace Assi1.Aggregates
{
    interface Aggregate
    {
        IIterator CreateIterator();
    }
}
