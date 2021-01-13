![.NET](https://github.com/aimenux/StringConcatenationBenchDemo/workflows/.NET/badge.svg)

# StringConcatenationBenchDemo
```
Benchmarking some string concatenation ways
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark various ways of string concatenation :
> :one: Using plus operator
> :two: Using concat method
> :three: Using join method
> :four: Using format method
> :five: Using interpolation
> :six: Using string builder

**`Tools`** : vs19, net core 3.1

```
|             Method |    N |          Mean |         Error |        StdDev |        Median |           Min |             Max | Rank |     Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |----- |--------------:|--------------:|--------------:|--------------:|--------------:|----------------:|-----:|----------:|------:|------:|----------:|
|  UsingConcatMethod |   10 |      87.19 ns |      0.680 ns |      0.568 ns |      87.16 ns |      86.37 ns |        88.11 ns |    1 |    0.0585 |     - |     - |     184 B |
|    UsingJoinMethod |   10 |     147.47 ns |      2.828 ns |      2.507 ns |     147.08 ns |     143.64 ns |       152.06 ns |    2 |    0.0587 |     - |     - |     184 B |
| UsingStringBuilder |   10 |     224.96 ns |      3.106 ns |      2.906 ns |     224.33 ns |     219.99 ns |       229.88 ns |    3 |    0.2320 |     - |     - |     728 B |
|  UsingPlusOperator |   10 |     227.24 ns |      3.720 ns |      4.284 ns |     225.93 ns |     222.06 ns |       238.92 ns |    3 |    0.3440 |     - |     - |    1080 B |
|  UsingConcatMethod |  100 |     846.35 ns |     16.556 ns |     19.709 ns |     841.68 ns |     824.72 ns |       896.73 ns |    4 |    0.5760 |     - |     - |    1808 B |
| UsingStringBuilder |  100 |   1,229.45 ns |     12.930 ns |     11.462 ns |   1,227.54 ns |   1,216.78 ns |     1,258.25 ns |    5 |    1.3885 |     - |     - |    4360 B |
|    UsingJoinMethod |  100 |   1,335.30 ns |     22.536 ns |     21.080 ns |   1,331.29 ns |   1,305.32 ns |     1,370.46 ns |    6 |    0.5760 |     - |     - |    1808 B |
|  UsingConcatMethod | 1000 |   8,629.91 ns |    139.372 ns |    108.812 ns |   8,649.91 ns |   8,422.61 ns |     8,750.04 ns |    7 |    6.2866 |     - |     - |   19808 B |
|  UsingPlusOperator |  100 |  10,339.26 ns |    202.395 ns |    277.041 ns |  10,324.17 ns |   9,936.35 ns |    10,959.65 ns |    8 |   29.1443 |     - |     - |   91440 B |
| UsingStringBuilder | 1000 |  11,748.81 ns |    226.236 ns |    324.461 ns |  11,644.45 ns |  11,348.24 ns |    12,608.83 ns |    9 |   16.8457 |     - |     - |   52984 B |
|    UsingJoinMethod | 1000 |  13,789.84 ns |    270.765 ns |    515.158 ns |  13,606.67 ns |  13,139.12 ns |    15,367.13 ns |   10 |    6.2866 |     - |     - |   19808 B |
|  UsingPlusOperator | 1000 | 960,286.15 ns | 18,011.021 ns | 50,504.835 ns | 939,399.61 ns | 901,508.01 ns | 1,090,449.41 ns |   11 | 3124.0234 |     - |     - | 9825840 B |