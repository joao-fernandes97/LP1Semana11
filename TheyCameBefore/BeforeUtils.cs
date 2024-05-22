using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T cutoff) where T:struct, IComparable
        {
            foreach (T item in items)
            {
                if (item.CompareTo(cutoff)<0)
                {
                    yield return item;
                }
            }
        } 
    }
}