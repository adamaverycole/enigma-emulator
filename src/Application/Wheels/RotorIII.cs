namespace Application.Wheels;

public class RotorIII : Wheel
{
    protected override char[] CharacterMapping => "BDFHJLCPRTXVZNYEIWGAKMUSQO".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "D";

    protected override string WindowLocations => "V";

    protected override string TurnoverLocations => "W";
}