using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AnyCountExist;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class PerformanceCheck
{
    private int targetNumber;
    private List<int> numbers = [];

    [GlobalSetup]
    public void GlobalSetup()
    {
        targetNumber = 10000001;
        numbers = Enumerable.Range(0, 10000000).ToList();
    }

    [Benchmark]
    public void Performance_Any()
    {
        _ = numbers.Any(x => x == targetNumber);
    }

    [Benchmark]
    public void Performance_Count()
    {
        _ = numbers.Count(x => x == targetNumber) > 0;
    }

    [Benchmark]
    public void Performance_Exists()
    {
        _ = numbers.Exists(x => x == targetNumber);
    }
}