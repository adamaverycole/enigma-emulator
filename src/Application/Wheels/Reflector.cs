namespace Application.Wheels;

public abstract class Reflector
{
    private char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    protected abstract char[] CharacterMapping { get; }
        
    public char SubstituteCharacter(char character)
    {
        return alphabet[Array.IndexOf(CharacterMapping, character)];
    }
}