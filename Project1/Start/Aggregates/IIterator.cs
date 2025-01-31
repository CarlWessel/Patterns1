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
 *  Purpose: Interface methods to traverse a collection using First(), GetPrevious(), Next(), IsDone(), and CurrentItem()
 */

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
