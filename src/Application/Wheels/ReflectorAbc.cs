namespace Application.Wheels;

public class ReflectorAbc : Reflector
{
    protected override char[] CharacterMapping => "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ
}