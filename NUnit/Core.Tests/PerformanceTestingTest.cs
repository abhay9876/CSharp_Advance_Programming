using Core;
using NUnit.Framework;
using System.Reflection;

[TestFixture]
public class PerformanceTestingTest
{
    private PerformanceTesting _pt;

    [SetUp]
    public void Setup()
    {
        _pt = new PerformanceTesting();
    }

    [Test]
    [Timeout(3500)]
    public void Input_ReturnOnTime()
    {
        bool result = _pt.LongRunningTask();
        Assert.AreEqual(true, result);
    }



}