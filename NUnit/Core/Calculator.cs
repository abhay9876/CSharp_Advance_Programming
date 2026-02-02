/*Basic NUnit Test: Testing a Calculator Class
Problem:
Create a Calculator class with methods:
● Add(int a, int b)
● Subtract(int a, int b)
● Multiply(int a, int b)
● Divide(int a, int b)
Write NUnit or MSTest test cases for each method.
 */







namespace Core;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        return a / b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

}

