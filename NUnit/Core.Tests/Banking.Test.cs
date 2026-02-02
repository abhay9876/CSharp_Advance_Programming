
using Core;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class BankAccountTests
{
    private BankAccount account;

    [SetUp]
    public void Setup()
    {
        account = new BankAccount(100);
    }

    [Test]
    public void Deposit_ShouldIncrease()
    {
        double depositAmount = 50;
        account.Deposit(depositAmount);
        Assert.AreEqual(150, account.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldReduceBalance()
    {
        double withdrawAmount = 40;
        bool result = account.Withdraw(withdrawAmount);
        Assert.IsTrue(result);
        Assert.AreEqual(60, account.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldFailAndNotChangeBalance()
    {
        double withdrawAmount = 150;
        bool result = account.Withdraw(withdrawAmount);
        Assert.IsFalse(result);
        Assert.AreEqual(100, account.GetBalance());
    }
}
