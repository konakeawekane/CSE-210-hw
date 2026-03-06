public abstract class Animal : IMoveable
{
    private string _name;

    public Animal(string name)
    {
        _name = name;
    }
    public abstract string GetSound();
    public abstract string getMoveType();

    public string GetDescription()
    {
        return $"{_name} makes sound of {GetSound()}";
    }
}