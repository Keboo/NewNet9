using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace NewNet9;

public partial class Benchmarks
{
    private object _conventionalLock = new();
    private int _addition = 0;
    [Benchmark]
    public void Scenario1()
    {
        lock (_conventionalLock)
        {
            _addition++;
        }
    }
}
