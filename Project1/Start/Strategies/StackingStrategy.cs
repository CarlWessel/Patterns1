﻿using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public interface StackingStrategy
    {
        float EvaluateStack(HeavyObjectList input);
    }
}
