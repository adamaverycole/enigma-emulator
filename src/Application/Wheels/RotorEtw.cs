namespace Application.Wheels;

public class RotorEtw : Wheel
{
    protected override char[] CharacterMapping => "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "";

    protected override string WindowLocations => "";

    protected override string TurnoverLocations => "";
}