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

    /// <summary>
    /// > With the rotors I, II, III (from left to right), wide B-reflector, all ring settings in B-position, and start position AAA, typing AAAAA will produce the encoded sequence EWTYX.
    /// <see href="https://en.wikipedia.org/wiki/Enigma_rotor_details#Ring_setting">source</see>.
    /// </summary>
    [Test]
    public void TypeMessage_WhenPlainTextIsAAAAA_ShouldGetCipherEWTYX()
    {
        const string plainText = "AAAAA";
        const string expectedCipher = "EWTYX";
        
        sut = new EnigmaMachine(new RotorAssembly());
        sut.ConfigureReflector(new ReflectorB());
        sut.ConfigureWheelOrder(new RotorI(), new RotorII(), new RotorIII(), null, null);
        sut.ConfigureRingSettings('B', 'B', 'B', null, null);
        sut.ConfigureIndicatorGroups("AAA");
        string cipherResponse = sut.TypeMessage(plainText);

        Assert.That(cipherResponse, Is.EqualTo(expectedCipher));
    }
}