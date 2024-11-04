using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace NewNet9;

public partial class Benchmarks
{
    private System.Threading.Lock _newLock = new System.Threading.Lock();
    private int _addition2 = 0;
    [Benchmark]
    public void Scenario2()
    {
        lock(_newLock)
        {
            _addition2++;
        }
    }

    
    private System.Threading.Lock _usingLock = new System.Threading.Lock();
    private int _addition3 = 0;
    [Benchmark]
    public void Scenario3()
    {
        using(_usingLock.EnterScope())
        {
            _addition3++;
        }
    }
}
