using Core;
using NUnit.Framework;
using System.Reflection;

[TestFixture]
public class ParameterizedTest
{
    private Parameterized _para;

    [SetUp]
    public void Setup()
    {
        _para = new Parameterized();
    }

    [Test]
    public void Input2_ShouldBeReturnTrue()
    {
        bool result = _para.IsEven(2);
        Assert.AreEqual(true, result);
    }

    [Test]
    public void Input4_ShouldBeReturnTrue()
    {
        bool result = _para.IsEven(4);
        Assert.AreEqual(true, result);
    }

    [Test]
    public void Input6_ShouldBeReturnTrue()
    {
        bool result = _para.IsEven(6);
        Assert.AreEqual(true, result);
    }

    [Test]
    public void Input7_ShouldBeReturnFalse()
    {
        bool result = _para.IsEven(7);
        Assert.AreEqual(false, result);
    }

    [Test]
    public void Input9_ShouldBeReturnFalse()
    {
        bool result = _para.IsEven(9);
        Assert.AreEqual(false, result);
    }

}