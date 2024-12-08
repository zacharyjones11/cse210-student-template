using System;

class Program
{
    static void Main(string[] args)
    {

        Address usaAddress = new Address("123 Main St", "Springfield", "IL", "USA");
        Address internationalAddress = new Address("456 2nd st", "Toronto", "ON", "Canada");

        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer internationalCustomer = new Customer("Jane Smith", internationalAddress);

        Product laptop = new Product("Laptop", "P0001", 1000, 1);
        Product mouse = new Product("Mouse", "P0002", 50, 2);
        Product keyboard = new Product("Keyboard", "P0003", 150, 1);
        Product headphones = new Product("Headphones", "P0004", 250, 1);

        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(laptop);
        usaOrder.AddProduct(mouse);
        usaOrder.AddProduct(keyboard);

        Order internationalOrder = new Order(internationalCustomer);
        internationalOrder.AddProduct(headphones);
        internationalOrder.AddProduct(mouse);

        Console.WriteLine("USA Order:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(usaOrder.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(usaOrder.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${usaOrder.CalculateTotalPrice()}");

        Console.WriteLine("\n" + new string('-', 40) + "\n");

        Console.WriteLine("International Order:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(internationalOrder.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(internationalOrder.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${internationalOrder.CalculateTotalPrice()}");
    }
}