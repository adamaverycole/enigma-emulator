namespace Application.Wheels;

public class RotorVIII : Wheel
{
    protected override char[] CharacterMapping => "FKQHTLXOCBJSPDZRAMEWNIUYGV".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "HU";

    protected override string WindowLocations => "ZM";

    protected override string TurnoverLocations => "AN";
}