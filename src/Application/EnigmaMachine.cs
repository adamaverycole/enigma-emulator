using Application.Wheels;

public class EnigmaMachine(RotorAssembly rotorAssembly) : IEnigmaMachine
{
    public Wheel RotorA { get; private set; }
    public Wheel RotorB { get; private set; }
    public Wheel RotorC { get; private set; }
    public Wheel RotorD { get; private set; }
    public Wheel RotorE { get; private set; }
    public Reflector Reflector { get; private set; }

    private RotorAssembly rotorAssembly = rotorAssembly;

    public void ConfigureIndicatorGroups(string characters)
    {
        throw new NotImplementedException();
    }

    public void ConfigurePlugBoardConnections(string characters)
    {
        throw new NotImplementedException();
    }

    public void ConfigureReflector(Reflector reflector)
    {
        Reflector = reflector;
    }

    public void ConfigureRingSettings(char rotorA, char? rotorB, char? rotorC, char? rotorD, char? rotorE)
    {
        throw new NotImplementedException();
    }

    public void ConfigureWheelOrder(Wheel rotorA, Wheel rotorB, Wheel? rotorC, Wheel? rotorD, Wheel? rotorE)
    {
        RotorA = rotorA;
        RotorB = rotorB;
        RotorC = rotorC;
        RotorD = rotorD;
        RotorE = rotorE;
    }

    public string TypeMessage(string message)
    {
        throw new NotImplementedException();
    }
}

public interface IEnigmaMachine
{
    void ConfigureWheelOrder(Wheel rotorA, Wheel? rotorB, Wheel? rotorC, Wheel? rotorD, Wheel? rotorE);
    void ConfigureRingSettings(char rotorA, char? rotorB, char? rotorC, char? rotorD, char? rotorE);
    void ConfigureReflector(Reflector reflector);
    void ConfigurePlugBoardConnections(string characters);
    void ConfigureIndicatorGroups(string characters);
    string TypeMessage(string message);
}