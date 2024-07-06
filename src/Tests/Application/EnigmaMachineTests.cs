using Application.Wheels;

namespace Tests.Application;

public class EnigmaMachineTests
{
    private EnigmaMachine sut;

    [SetUp]
    public void Setup()
    {
        sut = new EnigmaMachine(new RotorAssembly());
        var rotorA = new RotorEtw();
        var rotorB = new RotorEtw();
        var rotorC = new RotorEtw();
        var reflector = new ReflectorAbc();
        // sut.ConfigureWheelOrder(rotorA, rotorB, rotorC);
        sut.ConfigureReflector(reflector);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}