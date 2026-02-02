


using Core;
using NUnit.Framework;
using System.Reflection;

[TestFixture]
public class SetupAndTeardownTest
{

    private DatabaseConnection _db;

    [SetUp]
    public void Setup()
    {
        _db = new DatabaseConnection();
        _db.Connect();
    }

    [TearDown]
    public void Teardown()
    {
        _db.Disconnect();
    }

    [Test]
    public void Connection_ShouldBe_Connected()
    {
        Assert.That(_db.IsConnect, Is.True);
    }

    [Test]
    public void Connection_ShouldBe_DisConnected()
    {
        _db.Disconnect();
        Assert.That(_db.IsConnect, Is.False);
    }
}
