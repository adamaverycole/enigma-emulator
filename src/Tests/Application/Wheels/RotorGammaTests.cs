using Application.Wheels;

namespace Tests.Application.Wheels;

public class RotorGammaTests
{
    private RotorGamma sut;
    private string abcs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string cipher = "FSOKANUERHMBTIYCWLQPZXVGJD";

    [SetUp]
    public void Setup()
    {
        sut = new RotorGamma();
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