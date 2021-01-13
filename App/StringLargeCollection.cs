using BenchmarkDotNet.Attributes;
using System.Linq;
using System.Text;

namespace App
{
    [Config(typeof(StringBenchConfig))]
    public class StringLargeCollection
    {
        private string[] items;

        [Params(10, 50, 100)]
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
        public string UsingForeachConcatMethod()
        {
            var result = string.Empty;

            foreach (var item in items)
            {
                result = string.Concat(result, item);
            }

            return result;
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
