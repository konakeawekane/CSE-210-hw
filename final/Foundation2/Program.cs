using System;

class Program
{
    static void Main(string[] args)
    {
        Address bobAddress = new Address("421 Oak St", "Phoenix", "AZ", "USA");
        Address jackAddress = new Address("1002 Langdon Rd", "Calgary", "AB", "Canada");

        Order o1 = new Order(new Customer("Bob", bobAddress));
        Order o2 = new Order(new Customer("Jack", jackAddress));

        Product p1 = new Product("Chair", "CH1231", 45.54f, 2);
        Product p2 = new Product("Stool", "ST1521", 30.00f, 1);

        Product p21 = new Product("Bench", "BN9542", 55.00f, 2);
        Product p22 = new Product("Plates", "PL6742", 32.99f, 2);
        Product p23 = new Product("Utensil Pack", "UT(4684)", 22.99f, 1);

        o1.AddProduct(p1);
        o1.AddProduct(p2);

        o2.AddProduct(p21);
        o2.AddProduct(p22);
        o2.AddProduct(p23);

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total - {o1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total - {o2.GetTotalCost():F2}");
    }
}