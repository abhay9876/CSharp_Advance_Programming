using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [TestCase(25, 77)]
    [TestCase(37, 98.6)]
    [TestCase(-10, 14)]
    public void CelsiusToFahrenheit_ShouldReturnValue(double celsius, double expectedFahrenheit)
    {
        double result = converter.CelsiusToFahrenheit(celsius);

        Assert.AreEqual(expectedFahrenheit, result);
    }

    [TestCase(77, 25)]
    [TestCase(98.6, 37)]
    [TestCase(14, -10)]
    public void FahrenheitToCelsius_ShouldReturnValue(double fahrenheit, double expectedCelsius)
    {
        double result = converter.FahrenheitToCelsius(fahrenheit);

        Assert.AreEqual(expectedCelsius, result);
    }
}
