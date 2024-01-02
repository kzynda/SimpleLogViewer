namespace Common.Tests;

public class DummyClassTests    
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        DummyClass dummy = new();
        
        Assert.That(dummy.Add(1, 1), Is.EqualTo(2));
    }
}