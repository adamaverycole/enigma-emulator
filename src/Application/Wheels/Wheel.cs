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
    
    // public char CurrentCharacter { get; private set; }
    
    public char SubstituteCharacterLeftToRight(char character)
    {
        return alphabet[Array.IndexOf(CharacterMapping, character)];
    }
    
    public char SubstituteCharacterRightToLeft(char character)
    {
        return CharacterMapping[Array.IndexOf(alphabet, character)];
    }
}