﻿using System;
using System.Collections.Generic;
using System.Text;

/*
 * Group memebers:
 *  Carl Wessel
 *  Cody Sykes
 *  Trishia Salamangkit
 *  Ethan Reimer
 *  
 *  Purpose: Class that implements Aggregate for storing heavyObject allowing iteration to use HeavyObjectIterator
 */

namespace Assi1.Aggregates
{
    public class HeavyObjectList : Aggregate
    {
        protected List<HeavyObject> container = new List<HeavyObject>();

        public IIterator CreateIterator()
        {
            return new HeavyObjectIterator(this);
        }

        public void Add(HeavyObject item)
        {
            container.Add(item);
        }

        public HeavyObject At(int position)
        {
            return container[position];
        }

        public int Length()
        {
            return container.Count;
        }

        public void Print()
        {
            foreach (var item in container)
            {
                if (item is HeavyObject heavyObj)
                {
                    heavyObj.Print();
                }
                else
                {
                    Console.WriteLine(item?.ToString());
                }
            }
        }
    }

}
