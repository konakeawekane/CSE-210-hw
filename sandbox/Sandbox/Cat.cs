public class Cat : Animal
{
    public Cat() : base("Garfild")
    {
        
    }
    public override string GetSound()
    {
        return "Meow!";
    }

    public override string getMoveType()
    {
        return "Sprint";
    }
}