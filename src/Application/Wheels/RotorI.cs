namespace Application.Wheels;

public class RotorI : Wheel
{
    protected override char[] CharacterMapping => "EKMFLGDQVZNTOWYHXUSPAIBRCJ".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "Y";

    protected override string WindowLocations => "Q";

    protected override string TurnoverLocations => "R";
}