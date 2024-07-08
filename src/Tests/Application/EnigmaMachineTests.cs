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
        
        sut = new EnigmaMachine(new RotorAssembly(), new ReflectorB(), new RotorI(), new RotorII(), new RotorIII());
        sut.ConfigureRingSettings('B', 'B', 'B');
        sut.ConfigureInitialRingPositions('A', 'A', 'A');
        string cipherResponse = sut.TypeMessage(plainText);

        Assert.That(cipherResponse, Is.EqualTo(expectedCipher));
    }
}