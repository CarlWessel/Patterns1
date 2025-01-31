﻿using Assi1.Strategies;
using System;
using System.Collections.Generic;
using System.Text;
using static Assi1.Flyweights.FlyweightFactory;

/*
 * Group memebers:
 *  Carl Wessel
 *  Cody Sykes
 *  Trishia Salamangkit
 *  Ethan Reimer
 *  
 *  Purpose: Flyweight pattern used to reuse stacking strategy instances
 */

namespace Assi1.Flyweights
{
    public class FlyweightFactory
    {
        public enum StrategyType
        {
            BottomWeight,
            Pyramid,
            Topple
        }

        protected Dictionary<StrategyType, IStackingStrategy> strategies;

        public FlyweightFactory()
        {
            strategies = new Dictionary<StrategyType, IStackingStrategy>();
        }

        public IStackingStrategy GetFlyweight(string inputType)
        {
            IStackingStrategy strat;
            StrategyType type;

            if(inputType.Equals("bottomWeight"))
            {
                type = StrategyType.BottomWeight;
            }
            else if (inputType.Equals("pyramid"))
            {
                type = StrategyType.Pyramid;
            }
            else if (inputType.Equals("topple"))
            {
                type= StrategyType.Topple;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Not a valid stacking strategy.");
            }

            if (strategies.ContainsKey(type))
            {
                strat = strategies[type];
            }
            else
            {
                switch (type)
                {
                    case StrategyType.BottomWeight:
                        strat = new StackingStrategy_BottomWeight();
                        break;
                    case StrategyType.Pyramid:
                        strat = new StackingStrategy_Pyramid();
                        break;
                    case StrategyType.Topple:
                        strat = new StackingStrategy_Topple();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, "Bad Strategy Type");
                }
                strategies[type] = strat;
            }
            return strat;
        }
    }
}