namespace Application.Wheels;

public class RotorBeta : Wheel
{
    protected override char[] CharacterMapping => "LEYJVCNIXWPBQMDRTAKZGFUHOS".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "";

    protected override string WindowLocations => "";

    protected override string TurnoverLocations => "";
}