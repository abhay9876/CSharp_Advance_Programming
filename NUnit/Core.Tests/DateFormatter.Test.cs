using Core;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class DateFormatterTests
{
    [Test]
    public void FormatDate_ValidInput()
    {
        DateFormatter df = new DateFormatter();

        string result = df.FormatDate("2026-01-20");

        Assert.AreEqual("20-01-2026", result);
    }

    [Test]
    public void FormatDate_InvalidInput()
    {
        DateFormatter df = new DateFormatter();

        string result = df.FormatDate("20/01/2026");

        Assert.AreEqual("Invalid", result);
    }
}
