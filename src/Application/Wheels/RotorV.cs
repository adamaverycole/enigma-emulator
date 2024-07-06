namespace Application.Wheels;

public class RotorV : Wheel
{
    protected override char[] CharacterMapping => "VZBRGITYUPSDNHLXAWMJQOFECK".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "H";

    protected override string WindowLocations => "Z";

    protected override string TurnoverLocations => "A";
}