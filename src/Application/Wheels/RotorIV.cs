namespace Application.Wheels;

public class RotorIV : Wheel
{
    protected override char[] CharacterMapping => "ESOVPZJAYQUIRHXLNFTGKDCMWB".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "R";

    protected override string WindowLocations => "J";

    protected override string TurnoverLocations => "K";
}