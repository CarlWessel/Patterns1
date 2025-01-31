using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

/*
 * Group memebers:
 *  Carl
 *  Cody
 *  Trish
 *  Ethan
 *  
 *  Purpose:
 */

namespace Assi1.Strategies
{
    class StackingStrategy_BottomWeight : IStackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            float point = 0;
            int current = 1;

            for (IIterator i = input.CreateIterator(); !i.IsDone(); i.Next())
            {
                HeavyObject heavyobj = i.CurrentItem();
                point += heavyobj.Mass / ((float)current);
                current++;
            }

            return point;
        }
    }
}
