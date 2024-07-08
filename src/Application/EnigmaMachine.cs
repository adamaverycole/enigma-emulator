using Application.Wheels;

public class EnigmaMachine(RotorAssembly rotorAssembly, Reflector reflector, Wheel rotorA, Wheel rotorB, Wheel rotorC) : IEnigmaMachine
{
    public Wheel RotorA { get; private set; } = rotorA;
    public Wheel RotorB { get; private set; } = rotorB;
    public Wheel RotorC { get; private set; } = rotorC;
    public char RotorARingSetting { get; private set; } 
    public char RotorBRingSetting { get; private set; }
    public char RotorCRingSetting { get; private set; }
    public char RotorAInitialRingPosition { get; private set; } 
    public char RotorBInitialRingPosition { get; private set; }
    public char RotorCInitialRingPosition { get; private set; }
    public string PlugboardSettings { get; private set; }
    public Reflector Reflector { get; private set; } = reflector;

    private RotorAssembly rotorAssembly = rotorAssembly;

    public void ConfigurePlugBoardConnections(string characters)
    {
        PlugboardSettings = characters;
    }

    public void ConfigureRingSettings(char rotorA, char rotorB, char rotorC)
    {
        RotorARingSetting = rotorA;
        RotorBRingSetting = rotorB;
        RotorCRingSetting = rotorC;
    }

    public void ConfigureInitialRingPositions(char rotorA, char rotorB, char rotorC)
    {
        RotorAInitialRingPosition = rotorA;
        RotorBInitialRingPosition = rotorB;
        RotorCInitialRingPosition = rotorC;
    }

    public string TypeMessage(string message)
    {
        return message;
    }
}

public interface IEnigmaMachine
{
    void ConfigureRingSettings(char rotorA, char rotorB, char rotorC);
    void ConfigureInitialRingPositions(char rotorA, char rotorB, char rotorC);
    void ConfigurePlugBoardConnections(string characters);
    string TypeMessage(string message);
}