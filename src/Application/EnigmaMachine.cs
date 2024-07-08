using Application.Wheels;

public class EnigmaMachine(RotorAssembly rotorAssembly) : IEnigmaMachine
{

    public string PlugboardSettings { get; private set; }

    private RotorAssembly rotorAssembly = rotorAssembly;

    public void ConfigurePlugBoardConnections(string characters)
    {
        PlugboardSettings = characters;
    }

    public string TypeMessage(string message)
    {
        // 1. Keyboard to Plugboard
        // 2. Plugboard to Rotor Assembly
        // 2.1. Rotate Wheels
        // 2.2. Wheel 3 (right) to Wheel 2 (center)
        // 2.3. Wheel 2 (center) to Wheel 1 (left)
        // 2.4. Wheel 1 (left) to Reflector
        // 2.5. Reflector to Wheel 1 (left)
        // 2.6. Wheel 1 (left) to Wheel 2 (center)
        // 2.7. Wheel 2 (center) to wheel 3 (right)
        // 3. Rotor Assembly to Plugboard
        // 4. Plugboard to Lampboard

        char[] resultCharArray = new char[message.Length];
        char[] messageCharArray = message.ToCharArray();

        for (int i = 0; i < message.Length; i++)
        {
            resultCharArray[i] = rotorAssembly.SubstituteCharacter(messageCharArray[i]);
        }

        return new string(resultCharArray);
    }
}

public interface IEnigmaMachine
{
    void ConfigurePlugBoardConnections(string characters);
    string TypeMessage(string message);
}