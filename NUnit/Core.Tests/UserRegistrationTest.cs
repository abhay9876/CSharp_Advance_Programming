using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationTests
{
    [Test]
    public void ValidInput_ShouldNotThrowException()
    {
        UserRegistration reg = new UserRegistration();

        Assert.DoesNotThrow(() =>
            reg.RegisterUser("Abhay", "abhay@gmail.com", "pass123")
        );
    }

    [Test]
    public void InvalidInput_ShouldThrowException()
    {
        UserRegistration reg = new UserRegistration();

        Assert.Throws<ArgumentException>(() =>
            reg.RegisterUser("", "ABCDEF", "123")
        );
    }
}
