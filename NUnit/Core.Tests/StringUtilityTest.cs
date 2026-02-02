using Core;
using NUnit.Framework;
using System.Reflection;

[TestFixture]
public class StringUtilityTest
{
    private StringUtils _utility;

    [SetUp]
    public void Setup()
    {
        _utility = new StringUtils();
    }

    [Test]
    public void ShouldReturn_Reverse()
    {
        string result = _utility.Reverse("Hello");
        Assert.AreEqual("olleH", result);
    }

    [Test]
    public void ShouldReturn_Palindrome_True()
    {
        bool result = _utility.IsPalindrome("abababa");
        Assert.AreEqual(true, result);
    }

    [Test]
    public void ShouldReturn_UpperCase()
    {
        string result = _utility.ToUpperCases("hello");
        Assert.AreEqual("HELLO", result);
    }
}