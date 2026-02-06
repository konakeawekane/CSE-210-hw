using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for(int i = 0; i < 20; i++)
        {
            Fraction fraction = new Fraction(random.Next(1,9),random.Next(1,9));
            Console.WriteLine($"Fraction {i} String: {fraction.GetFractionString()} Decimal: {fraction.GetDecimalValue()}");
        }
    }
}
