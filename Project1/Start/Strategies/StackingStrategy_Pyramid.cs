using Assi1.Aggregates;
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
 *  Purpose: Implements the IStackingStrategy interface and evaluates a stack based on a pyramid-like structure. It rewards stacks where each object is smaller in width and length than the one below it.
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
