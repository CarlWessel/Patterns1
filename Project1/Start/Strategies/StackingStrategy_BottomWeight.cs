using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

/*
 * Group memebers:
 *  Carl Wessel
 *  Cody Sykes
 *  Trishia Salamangkit
 *  Ethan Reimer
 *  
 *  Purpose: Implements the IStackingStrategy interface and evaluates a stack of Heavy Objects using a weighted approach. Rewards stacks where weight is concentrated near the bottom of the stack.
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
