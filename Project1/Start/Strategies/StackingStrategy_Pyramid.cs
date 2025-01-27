using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public class StackingStrategy_Pyramid : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            float point = 0;

            for (Iterator i = input.CreateIterator(); !i.IsDone(); i.Next())
            {
                // See note in StackingStrategy_BottomWeight.cs
                HeavyObject heavyobj = i.CurrentItem();
                HeavyObject prevobj = i.GetPreviousItem();

                if (prevobj != null)
                {
                    point += (((heavyobj.Width * heavyobj.Length) < (prevobj.Width * prevobj.Length)) ? 1 : -1);
                }
            }

            return point;
        }
    }
}
