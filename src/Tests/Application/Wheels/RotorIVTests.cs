using Application.Wheels;

namespace Tests.Application.Wheels;

public class RotorIVTests
{
    private RotorIV sut;
    private string abcs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string cipher = "ESOVPZJAYQUIRHXLNFTGKDCMWB";

    [SetUp]
    public void Setup()
    {
        sut = new RotorIV();
    }

    [Test]
    public void SubstituteCharacterRightToLeft_ShouldSubstituteAbcsWith_Cipher()
    {
        char[] input = abcs.ToCharArray();
        char[] result = new char[input.Length];
        string expectedResult = cipher;
        for (int i = 0; i < abcs.Length; i++)
        {
            result[i] = sut.SubstituteCharacterRightToLeft(input[i]);
        }

        Assert.That(new string(result), Is.EqualTo(expectedResult));
    }

    [Test]
    public void SubstituteCharacterLeftToRight_ShouldSubstituteCipherWith_Abcs()
    {
        char[] input = cipher.ToCharArray();
        char[] result = new char[input.Length];
        string expectedResult = abcs;
        for (int i = 0; i < abcs.Length; i++)
        {
            result[i] = sut.SubstituteCharacterLeftToRight(input[i]);
        }

        Assert.That(new string(result), Is.EqualTo(expectedResult));
    }
}