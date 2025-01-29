using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace StringBenchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    public class StringConversionBenchmark
    {
        private const char TestChar = 'a';

        [Benchmark(Baseline = true)]
        public string ToStringMethod()
        {
            return TestChar.ToString();
        }

        [Benchmark]
        public string StringInterpolation()
        {
            return $"{TestChar}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var config = DefaultConfig.Instance
                .AddJob(Job.ShortRun
                    .WithWarmupCount(3)
                    .WithIterationCount(10));

            BenchmarkRunner.Run<StringConversionBenchmark>(config);
        }
    }
}
