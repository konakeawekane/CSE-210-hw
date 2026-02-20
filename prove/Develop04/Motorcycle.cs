public class Motorcycle : Vehicle
{
    private string _handlebarType;

    public Motorcycle(string handlebarType, int wheelNo) : base(wheelNo)
    {
        _handlebarType = handlebarType;   
    }
}