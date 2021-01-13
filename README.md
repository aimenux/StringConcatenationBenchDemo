![.NET 5.0](https://github.com/aimenux/StringConcatenationBenchDemo/workflows/.NET%205.0/badge.svg)

# StringConcatenationBenchDemo
```
Benchmarking various ways of string concatenation
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark various ways of string concatenation :
>
> :one: Using plus operator
>
> :two: Using concat method
>
> :three: Using join method
>
> :four: Using format method
>
> :five: Using interpolation
>
> :six: Using string builder
>

In order to run benchmarks, type these commands in your favorite terminal :
> :writing_hand: `.\App.exe --filter StringLittleCollection`
> :writing_hand: `.\App.exe --filter StringLargeCollection`

```
|                   Method |   N |        Mean |      Error |       StdDev |      Median |         Min |          Max | Rank |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------- |---- |------------:|-----------:|-------------:|------------:|------------:|-------------:|-----:|--------:|-------:|------:|----------:|
|        UsingConcatMethod |  10 |    60.59 ns |   1.157 ns |     2.173 ns |    60.59 ns |    56.87 ns |     66.58 ns |    1 |  0.0391 |      - |     - |     184 B |
|          UsingJoinMethod |  10 |   101.56 ns |   1.470 ns |     1.304 ns |   101.13 ns |    99.82 ns |    104.42 ns |    2 |  0.0391 |      - |     - |     184 B |
|        UsingPlusOperator |  10 |   156.28 ns |   3.102 ns |     2.902 ns |   155.47 ns |   153.09 ns |    161.41 ns |    3 |  0.2294 | 0.0002 |     - |    1080 B |
| UsingForeachConcatMethod |  10 |   157.31 ns |   3.100 ns |     3.807 ns |   157.18 ns |   150.97 ns |    163.80 ns |    3 |  0.2294 | 0.0002 |     - |    1080 B |
|       UsingStringBuilder |  10 |   178.90 ns |   3.128 ns |     2.926 ns |   178.82 ns |   174.38 ns |    184.82 ns |    4 |  0.1547 | 0.0002 |     - |     728 B |
|                          |     |             |            |              |             |             |              |      |         |        |       |           |
|        UsingConcatMethod |  50 |   297.74 ns |   5.545 ns |     6.163 ns |   296.15 ns |   289.67 ns |    309.00 ns |    1 |  0.1917 | 0.0005 |     - |     904 B |
|          UsingJoinMethod |  50 |   499.03 ns |   9.879 ns |    14.787 ns |   496.38 ns |   478.21 ns |    529.30 ns |    2 |  0.1917 |      - |     - |     904 B |
|       UsingStringBuilder |  50 |   617.40 ns |  12.305 ns |    28.761 ns |   615.04 ns |   569.47 ns |    692.43 ns |    3 |  0.5007 | 0.0038 |     - |    2360 B |
| UsingForeachConcatMethod |  50 | 2,060.39 ns |  41.094 ns |    81.115 ns | 2,060.96 ns | 1,917.72 ns |  2,275.04 ns |    4 |  4.9362 | 0.0267 |     - |   23240 B |
|        UsingPlusOperator |  50 | 2,086.83 ns |  45.127 ns |   129.477 ns | 2,052.46 ns | 1,898.97 ns |  2,465.42 ns |    4 |  4.9381 | 0.0267 |     - |   23240 B |
|                          |     |             |            |              |             |             |              |      |         |        |       |           |
|        UsingConcatMethod | 100 |   627.03 ns |  12.610 ns |    22.086 ns |   626.70 ns |   592.36 ns |    672.51 ns |    1 |  0.3834 | 0.0019 |     - |    1808 B |
|          UsingJoinMethod | 100 |   976.96 ns |  15.463 ns |    12.072 ns |   972.20 ns |   965.34 ns |  1,002.37 ns |    2 |  0.3834 | 0.0019 |     - |    1808 B |
|       UsingStringBuilder | 100 | 1,067.79 ns |  19.917 ns |    33.820 ns | 1,059.53 ns | 1,021.79 ns |  1,161.06 ns |    3 |  0.9251 | 0.0134 |     - |    4360 B |
| UsingForeachConcatMethod | 100 | 7,695.66 ns | 151.410 ns |   261.175 ns | 7,673.47 ns | 7,268.24 ns |  8,226.71 ns |    4 | 19.4244 | 0.2136 |     - |   91440 B |
|        UsingPlusOperator | 100 | 9,836.09 ns | 618.623 ns | 1,794.739 ns | 9,297.54 ns | 7,419.45 ns | 15,033.67 ns |    5 | 19.4244 | 0.2136 |     - |   91440 B |

**`Tools`** : vs19, net 5.0