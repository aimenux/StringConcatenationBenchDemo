using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;

namespace StringConcatenationBenchDemo
{
    public class StringBenchConfig : ManualConfig
    {
        public StringBenchConfig()
        {
            AddColumn(RankColumn.Arabic);
            AddExporter(HtmlExporter.Default);
            AddExporter(MarkdownExporter.Default);
            AddDiagnoser(MemoryDiagnoser.Default);
        }
    }
}
