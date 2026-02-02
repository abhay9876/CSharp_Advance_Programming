using Core;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [Test]
    public void ValidPassword_ShouldReturnTrue()
    {
        string password = "Ajdbgf12";

        bool result = validator.IsValid(password);

        Assert.IsTrue(result);
    }

    [TestCase("adjla1")]
    [TestCase("akjslaa")]
    [TestCase("ADAK")]
    [TestCase("abcd1234")]
    public void InvalidPassword_ShouldReturnFalse(string password)
    {
        bool result = validator.IsValid(password);

        Assert.IsFalse(result);
    }
}
