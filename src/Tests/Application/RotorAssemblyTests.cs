using Application.Wheels;

namespace Tests.Application;

public class RotorAssemblyTests
{
    private RotorAssembly sut;

    [SetUp]
    public void Setup()
    {
        sut = new RotorAssembly();
        var rotorA = new RotorEtw();
        var rotorB = new RotorEtw();
        var rotorC = new RotorEtw();
        var reflector = new ReflectorAbc();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}