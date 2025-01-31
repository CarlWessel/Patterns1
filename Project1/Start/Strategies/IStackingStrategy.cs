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
 *  Purpose: Strategy Interface to evaluate list of heavy objects via input
 */

namespace Assi1.Strategies
{
    public interface IStackingStrategy
    {
        float EvaluateStack(HeavyObjectList input);
    }
}
