using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        Console.Write("Enter number: ");
        int input = int.Parse(Console.ReadLine());

        while (!(input == 0))
        {
            numbers.Add(input);
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("You have entered no numbers");
        } else
        {
            int sum = 0;
            float avg = 0;
            int largest = numbers[0];
            int smallestPositive = -1;

            foreach (int number in numbers)
            {
                sum += number;
                if (number > largest) { largest = number; }
                if ((smallestPositive < 0) || (number < smallestPositive) && number > 0) { smallestPositive = number; }
            }

            avg = sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {avg}");
            Console.WriteLine($"The largest number is: {largest}");
            if (smallestPositive > 0)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            numbers.Sort();
            Console.WriteLine("The sorted list is:");

            foreach(int number in numbers)
            {
                Console.WriteLine(number.ToString());
            }

        }
        

    }
}