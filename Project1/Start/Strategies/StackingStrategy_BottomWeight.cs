using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace Assi1.Strategies
{
    public class StackingStrategy_BottomWeight : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            float point = 0;
            int current = 1;

            for (Iterator i = input.CreateIterator(); !i.IsDone(); i.Next())
            {
                HeavyObject heavyobj = i.CurrentItem(); // We may have to change type object to HeavyObject. (ex. object First() -> HeavyObject First(); in Iterator.cs)
                point += heavyobj.Mass / ((float)current);
                point++;
            }

            return point;
        }
    }
}
