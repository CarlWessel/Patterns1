using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace Assi1.Strategies
{
    class StackingStrategy_BottomWeight : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            float point = 0;
            int current = 1;

            for (Iterator i = input.CreateIterator(); !i.IsDone(); i.Next())
            {
                HeavyObject heavyobj = i.CurrentItem();
                point += heavyobj.Mass / ((float)current);
                point++;
            }

            return point;
        }
    }
}
