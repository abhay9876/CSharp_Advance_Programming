/*Testing Temperature Converter
Problem:
Create a TemperatureConverter class with:
● CelsiusToFahrenheit(double celsius): Converts Celsius to Fahrenheit.
● FahrenheitToCelsius(double fahrenheit): Converts Fahrenheit to Celsius.
Write unit tests to validate conversions.*/


public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
