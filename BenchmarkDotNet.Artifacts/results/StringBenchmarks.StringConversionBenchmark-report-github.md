```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
13th Gen Intel Core i5-1340P, 1 CPU, 16 logical and 12 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=10  LaunchCount=1  
WarmupCount=3  

```
| Method              | Mean      | Error     | StdDev    | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|-------------------- |----------:|----------:|----------:|------:|--------:|-----:|-------:|----------:|------------:|
| ToStringMethod      |  5.154 ns | 2.0678 ns | 1.2305 ns |  1.04 |    0.31 |    1 | 0.0038 |      24 B |        1.00 |
| StringInterpolation | 16.186 ns | 0.6966 ns | 0.4145 ns |  3.28 |    0.61 |    2 | 0.0038 |      24 B |        1.00 |
