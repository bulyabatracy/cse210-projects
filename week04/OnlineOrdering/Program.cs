using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (USA Customer)

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 800, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P102", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P103", 50, 1));


        // Second Order (International Customer)

        Address address2 = new Address(
            "45 Kampala Road",
            "Kampala",
            "Central",
            "Uganda");

        Customer customer2 = new Customer("Tracy Bulyaba", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P201", 500, 1));
        order2.AddProduct(new Product("Headphones", "P202", 80, 2));


        // Display Order 1

        Console.WriteLine("===== ORDER 1 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order1.CalculateTotalCost()}");


        // Display Order 2

        Console.WriteLine("\n==============================");

        Console.WriteLine("\n===== ORDER 2 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order2.CalculateTotalCost()}");
    }
}