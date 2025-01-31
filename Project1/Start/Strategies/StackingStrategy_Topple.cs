﻿using Assi1.Aggregates;
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
    class StackingStrategy_Topple : IStackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            float score = 0;
            IIterator iterator = input.CreateIterator();

            HeavyObject prevObject = null;

            while (!iterator.IsDone())
            {
                HeavyObject currentObject = iterator.CurrentItem();

                if (prevObject != null)
                {
                    bool isStable = (currentObject.Width < prevObject.Width) && (currentObject.Length < prevObject.Length);

                    if (isStable == true)
                    {
                        score -= 1;
                    }
                    else
                    {
                        score += 1;
                    }
                }

                prevObject = currentObject;
                iterator.Next();
            }

            return score;
        }
    }
}
