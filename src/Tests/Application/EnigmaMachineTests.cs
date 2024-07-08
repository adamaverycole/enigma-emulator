using Application.Wheels;

namespace Tests.Application;

public class EnigmaMachineTests
{
    private EnigmaMachine sut;

    [SetUp]
    public void Setup()
    {
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
        
        var rotorAssembly = new RotorAssembly(new ReflectorB(), new RotorI(), new RotorII(), new RotorIII());
        rotorAssembly.ConfigureRingSettings('B', 'B', 'B');
        rotorAssembly.ConfigureInitialRingPositions('A', 'A', 'A');
        sut = new EnigmaMachine(rotorAssembly);
        string cipherResponse = sut.TypeMessage(plainText);

        Assert.That(cipherResponse, Is.EqualTo(expectedCipher));
    }

    /// <summary>
    /// > With the rotors I, II, III (from left to right), wide B-reflector, all ring settings in A-position, and start position AAA, typing AAAAA will produce the encoded sequence BDZGO.
    /// <see href="https://en.wikipedia.org/wiki/Enigma_rotor_details#Ring_setting">source</see>.
    /// </summary>
    [Test]
    public void TypeMessage_WhenPlainTextIsAAAAA_ShouldGetCipherBDZGO()
    {
        const string plainText = "AAAAA";
        const string expectedCipher = "BDZGO";
        
        var rotorAssembly = new RotorAssembly(new ReflectorB(), new RotorI(), new RotorII(), new RotorIII());
        rotorAssembly.ConfigureRingSettings('A', 'A', 'A');
        rotorAssembly.ConfigureInitialRingPositions('A', 'A', 'A');
        sut = new EnigmaMachine(rotorAssembly);
        string cipherResponse = sut.TypeMessage(plainText);

        Assert.That(cipherResponse, Is.EqualTo(expectedCipher));
    }
}