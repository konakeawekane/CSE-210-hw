public class Cow : Animal
{
    public Cow() : base("Bettsy")
    {
        
    }

    public override string GetSound()
    {
        return "Moo!";
    }

    public override string getMoveType()
    {
        return "Talk";
    }
}