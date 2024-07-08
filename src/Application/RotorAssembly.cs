using Application.Wheels;

public class RotorAssembly(Reflector reflector, Wheel rotorA, Wheel rotorB, Wheel rotorC) : IRotorAssembly
{   
    public Wheel Wheel1 { get; private set; } = rotorA;
    public Wheel Wheel2 { get; private set; } = rotorB;
    public Wheel Wheel3 { get; private set; } = rotorC;
    public Reflector Reflector { get; private set; } = reflector;
    public char Wheel1RingSetting { get; private set; } 
    public char Wheel2RingSetting { get; private set; }
    public char Wheel3RingSetting { get; private set; }
    public char Wheel1InitialRingPosition { get; private set; } 
    public char Wheel2InitialRingPosition { get; private set; }
    public char Wheel3InitialRingPosition { get; private set; }

    public char SubstituteCharacter(char character)
    {
        StepRotors();
        char ltrWheel3Result = Wheel3.SubstituteCharacterLeftToRight(character);
        Console.Write(ltrWheel3Result);
        char ltrWheel2Result = Wheel2.SubstituteCharacterLeftToRight(ltrWheel3Result);
        Console.Write(ltrWheel2Result);
        char ltrWheel1Result = Wheel1.SubstituteCharacterLeftToRight(ltrWheel2Result);
        Console.Write(ltrWheel1Result);
        char reflectorResult = Reflector.SubstituteCharacter(ltrWheel1Result);
        Console.Write(reflectorResult);
        char rtlWheel1Result = Wheel1.SubstituteCharacterRightToLeft(reflectorResult);
        Console.Write(rtlWheel1Result);
        char rtlWheel2Result = Wheel2.SubstituteCharacterRightToLeft(rtlWheel1Result);
        Console.Write(rtlWheel2Result);
        char rtlWheel3Result = Wheel3.SubstituteCharacterRightToLeft(rtlWheel2Result);
        Console.Write(rtlWheel3Result);
        Console.WriteLine();
        return rtlWheel3Result;
    }

    private void StepRotors()
    {
        Wheel3.StepRotor();
    }

    public void ConfigureRingSettings(char wheel1, char wheel2, char wheel3)
    {
        Wheel1RingSetting = wheel1;
        Wheel2RingSetting = wheel2;
        Wheel3RingSetting = wheel3;
    }

    public void ConfigureInitialRingPositions(char wheel1, char wheel2, char wheel3)
    {
        Wheel1InitialRingPosition = wheel1;
        Wheel2InitialRingPosition = wheel2;
        Wheel3InitialRingPosition = wheel3;
    }
}

public interface IRotorAssembly
{
    void ConfigureRingSettings(char wheel1, char wheel2, char wheel3);

    void ConfigureInitialRingPositions(char wheel1, char wheel2, char wheel3);

    char SubstituteCharacter(char character);
}