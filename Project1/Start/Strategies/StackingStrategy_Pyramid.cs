using Assi1.Aggregates;
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
 *  Purpose: A strategy for comparing width and length of heavy weight objects to see which list of heavyobjects would topple the easiest
 */

namespace Assi1.Strategies
{
    class StackingStrategy_Pyramid : IStackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            float point = 0;
            int current = 0;
            for (IIterator i = input.CreateIterator(); !i.IsDone(); i.Next())
            {
                if(current != 0)
                {
                    HeavyObject heavyobj = i.CurrentItem();
                    HeavyObject prevobj = i.GetPreviousItem();
                    i.Next();
                    if (prevobj != null)
                    {
                        point += (((heavyobj.Width * heavyobj.Length) < (prevobj.Width * prevobj.Length)) ? 1 : -1);
                    }
                }
                current++;
            }

            return point;
        }
    }
}
