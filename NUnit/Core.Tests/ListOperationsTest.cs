using Core;
using NUnit.Framework;
using System.Reflection;

[TestFixture]
public class ListOperationsTest
{
    private ListManager _listManager;
    private List<int> list;

    [SetUp]
    public void Setup()
    {
        _listManager = new ListManager();
        list = new List<int> { 1, 2, 3 };
    }

    [Test]
    public void Element_ShouldBeAdded()
    {
        _listManager.AddElement(list, 4);
        Assert.Contains(4, list);
        Assert.AreEqual(4, list.Count);
    }


    [Test]
    public void Element_ShouldBeRemoved()
    {
        _listManager.RemoveElement(list, 4);
        //Assert.Contains(4, list);
        Assert.AreEqual(3, list.Count);
    }

    [Test]
    public void GetSize_OfLiSt()
    {
        int size = _listManager.GetSize(list);
        Assert.AreEqual(3, list.Count);
    }
}