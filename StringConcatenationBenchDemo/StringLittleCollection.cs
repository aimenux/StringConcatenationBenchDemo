using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Text;

namespace StringConcatenationBenchDemo
{
    [RankColumn]
    [MinColumn, MaxColumn]
    [Config(typeof(StringBenchConfig))]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class StringLittleCollection
    {
        private readonly string item1 = "string1";
        private readonly string item2 = "string2";
        private readonly string item3 = "string3";
        private readonly string item4 = "string4";
        private readonly string item5 = "string5";

        [Benchmark]
        public string UsingPlusOperator()
        {
            return item1 + item2 + item3 + item4 + item5;
        }

        [Benchmark]
        public string UsingConcatMethod()
        {
            return string.Concat(item1, item2, item3, item4, item5);
        }

        [Benchmark]
        public string UsingJoinMethod()
        {
            return string.Join("", item1, item2, item3, item4, item5);
        }

        [Benchmark]
        public string UsingFormatMethod()
        {
            return string.Format("{0}{1}{2}{3}{4}", item1, item2, item3, item4, item5);
        }

        [Benchmark]
        public string UsingInterpolation()
        {
            return $"{item1}{item2}{item3}{item4}{item5}";
        }

        [Benchmark]
        public string UsingStringBuilder()
        {
            var builder = new StringBuilder();
            builder.Append(item1);
            builder.Append(item2);
            builder.Append(item3);
            builder.Append(item4);
            builder.Append(item5);
            return builder.ToString();
        }
    }
}
