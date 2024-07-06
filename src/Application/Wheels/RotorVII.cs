namespace Application.Wheels;

public class RotorVII : Wheel
{
    protected override char[] CharacterMapping => "NZJHGRCXMYSWBOUFAIVLPEKQDT".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "HU";

    protected override string WindowLocations => "ZM";

    protected override string TurnoverLocations => "AN";
}