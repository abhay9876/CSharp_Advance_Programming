using NUnit.Framework;
using Core;
using System.Reflection;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_10_20_ShouldReturn30()
    {
        int result = _calculator.Add(10, 20);
        Assert.AreEqual(30, result);
    }

    [Test]
    public void Divide_10_By2_ShouldReturn5()
    {
        int result = _calculator.Divide(10, 2);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Multiply_10_By2_ShouldReturn20()
    {
        int result = _calculator.Multiply(10, 2);
        Assert.AreEqual(20, result);
    }
    [Test]
    public void Substract_10_By2_ShouldReturn8()
    {
        int result = _calculator.Subtract(10, 2);
        Assert.AreEqual(8, result);
    }

    [Test]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }
}
