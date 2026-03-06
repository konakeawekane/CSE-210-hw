public class Frog : Animal
{

    public Frog() : base("Kermit")
    {
        
    }
    public override string GetSound()
    {
        return "Ribbit!";
    }

    public override string getMoveType()
    {
        return "Jump";
    }
}