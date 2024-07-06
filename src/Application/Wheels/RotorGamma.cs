namespace Application.Wheels;

public class RotorGamma : Wheel
{
    protected override char[] CharacterMapping => "FSOKANUERHMBTIYCWLQPZXVGJD".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "";

    protected override string WindowLocations => "";

    protected override string TurnoverLocations => "";
}