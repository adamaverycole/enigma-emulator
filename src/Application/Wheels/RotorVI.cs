namespace Application.Wheels;

public class RotorVI : Wheel
{
    protected override char[] CharacterMapping => "JPGVOUMFYQBENHZRDKASXLICTW".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "HU";

    protected override string WindowLocations => "ZM";

    protected override string TurnoverLocations => "AN";
}