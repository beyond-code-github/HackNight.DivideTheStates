namespace HackNight.DivideTheStates.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        public static IDictionary<int, List<int>> Divide(int buckets, IEnumerable<int> inputs)
        {
            return Divide(buckets, inputs, x => x);
        }

        public static IDictionary<int, List<TValue>> Divide<TValue>(
            int buckets,
            IEnumerable<TValue> inputs,
            Func<TValue, int> metricProvider)
        {
            inputs = inputs.OrderByDescending(metricProvider);
            var output = new Dictionary<int, List<TValue>>();
            if (buckets > 1)
            {
                var count = 0;
                for (int i = 0; i < buckets; i++)
                {
                    var ratio = Math.Ceiling((double)inputs.Skip(count).Select(metricProvider).Sum() / (buckets - i));
                    var bucket = Total(inputs, ratio, metricProvider, count);
                    count += bucket.Count();
                    output.Add(i, bucket.ToList());

                }

                return output;
            }

            output.Add(0, inputs.ToList());

            return output;
        }

        private static IEnumerable<TValue> Total<TValue>(
            IEnumerable<TValue> inputs,
            double ratio,
            Func<TValue, int> metricProvider,
            int skip = 0)
        {
            var bucket1 = new List<TValue> { inputs.ElementAt(skip) };
            var total = bucket1.Select(metricProvider).Sum();
            bucket1.AddRange(inputs.Skip(skip + 1).TakeWhile(x => (total = total + metricProvider(x)) <= ratio));
            return bucket1.ToList();
        }
    }
}
