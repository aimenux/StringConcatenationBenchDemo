using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Linq;
using System.Text;

namespace StringConcatenationBenchDemo
{
    [RankColumn]
    [MinColumn, MaxColumn]
    [Config(typeof(StringBenchConfig))]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class StringLargeCollection
    {
        private string[] items;

        [Params(10, 100, 1000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            items = Enumerable.Range(0, N)
                .Select(x => $"String-{x}")
                .ToArray();
        }

        [Benchmark]
        public string UsingPlusOperator()
        {
            var result = string.Empty;

            foreach (var item in items)
            {
                result += item;
            }

            return result;
        }

        [Benchmark]
        public string UsingConcatMethod()
        {
            return string.Concat(items);
        }

        [Benchmark]
        public string UsingJoinMethod()
        {
            return string.Join("", items);
        }

        [Benchmark]
        public string UsingStringBuilder()
        {
            var builder = new StringBuilder();

            foreach (var item in items)
            {
                builder.Append(item);
            }

            return builder.ToString();
        }
    }
}
