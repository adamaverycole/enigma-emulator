namespace Application.Wheels;

public abstract class Reflector : Wheel
{

    // No reflector will ever rotate.
    sealed protected override string NotchLocations => "";
 
     // No reflector will ever rotate.
   sealed protected override string WindowLocations => "";

    // No reflector will ever rotate.
    sealed protected override string TurnoverLocations => "";
}