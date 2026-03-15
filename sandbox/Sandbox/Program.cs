using System;

class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Frog();
        Animal a2 = new Cow();
        Animal a3 = new Cat();
        List<Animal> animals = new List<Animal>();
        animals.AddRange(a1, a2, a3);

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.GetSound());
        }

        Console.WriteLine(a1.getMoveType());
        Console.WriteLine(a2.GetDescription());
        string grade = "A";
        string responce = grade == "A" ? "Good job" : "Don't quit";
        string responce2 = grade ?? "Dont quit";

        
    }
}