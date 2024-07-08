namespace Application.Wheels;

public abstract class Wheel 
{
    private char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    protected abstract char[] CharacterMapping { get; }
    
    /// <summary>
    /// Notch Locations gives the position/s of notches on the alphabet ring.
    /// </summary>
    protected abstract string NotchLocations { get; }
    
    /// <summary>
    /// Window Locations gives the letter/s which appear/s in the window when the notch is engaged. Note that the letters which appear in the window for rotors I, II, III, IV and V are Q, E, V, J and Z respectively, which are alphabetically immediately before R, F, W, K and A respectively, remembered at Bletchley Park by the mnemonic Royal Flags Wave Kings Above. The reason they are alphabetically displaced by one letter is that when the Enigma's key is pressed the rotors step and then the glow lamp lights.
    /// </summary>
    protected abstract string WindowLocations {get; }
    
    /// <summary>
    /// Turnover Locations gives the letter/s which appear/s in the window after the turnover has occurred.
    /// </summary>
    protected abstract string TurnoverLocations { get; }

    protected int StepOffset { get; set; }
    
    // public char CurrentCharacter { get; private set; }
    
    public char SubstituteCharacterLeftToRight(char character)
    {
        return CharacterMapping[Array.IndexOf(alphabet, character) - StepOffset];
    }
    
    public char SubstituteCharacterRightToLeft(char character)
    {
        return alphabet[Array.IndexOf(CharacterMapping, character) - StepOffset];
    }

    public void StepRotor()
    {
        StepOffset = (StepOffset > 0) ? StepOffset - 1 : 25;
        // Console.WriteLine("Shift Left Before: {0}", new string(CharacterMapping));
        // // char[] newMapping = new char[26];
        // // Array.Copy(CharacterMapping, 1, newMapping, 0, newMapping.Length - 1);
        // // CharacterMapping = newMapping;
        // Array.Copy(CharacterMapping, 1, CharacterMapping, 0, CharacterMapping.Length - 1);
        // Console.WriteLine("Shift Left After: {0}", new string(CharacterMapping));
        // // char t = CharacterMapping[CharacterMapping.Length - 1];
        // // for (int i = CharacterMapping.Length - 1; i > 0; i--)
        // //     CharacterMapping[i] = CharacterMapping[i - 1];
        // // CharacterMapping[0] = t;
    }
}