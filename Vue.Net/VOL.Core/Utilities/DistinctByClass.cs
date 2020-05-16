using System;
using System.Collections.Generic;

namespace VOL.Core.Utilities
{
    /// <summary>
    ///Distinct
    /// </summary>
    public static class DistinctByClass
    {
        /// <summary>
        ///2.使用方法如下（针对ID，和Name进行Distinct） 
        ///var query = people.DistinctBy(p => new { p.Id, p.Name });
        ///3.若仅仅针对ID进行distinct 
        ///var query = people.DistinctBy(p => p.Id);
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
