using BenchmarkDotNet.Running;

namespace StringConcatenationBenchDemo
{
    public static class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<StringLargeCollection>();
        }
    }
}
