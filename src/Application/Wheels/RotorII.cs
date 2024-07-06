namespace Application.Wheels;

public class RotorII : Wheel
{
    protected override char[] CharacterMapping => "AJDKSIRUXBLHWTMCQGZNPYFVOE".ToCharArray();
    //                                             ABCDEFGHIJKLMNOPQRSTUVWXYZ

    protected override string NotchLocations => "M";

    protected override string WindowLocations => "E";

    protected override string TurnoverLocations => "F";
}