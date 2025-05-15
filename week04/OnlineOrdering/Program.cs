using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm Street", "Salt Lake City", "UT", Address.CountryCode.US);
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book of Mormon", 101, 12.99, 2));
        order1.AddProduct(new Product("CTR Ring", 102, 5.50, 1));

        Address address2 = new Address("456 Maple Avenue", "Toronto", "ON", Address.CountryCode.CA);
        Customer customer2 = new Customer("Emily Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bible", 201, 18.99, 1));
        order2.AddProduct(new Product("Oil Vial", 202, 3.75, 3));
        order2.AddProduct(new Product("Tithing Envelopes", 203, 0.25, 10));

        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine("Packing Label:");
        order1.GetPackingLabel();
        Console.WriteLine("\nShipping Label:");
        order1.GetShippingLabel();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");

        Console.WriteLine("\n=== Order 2 ===");
        Console.WriteLine("Packing Label:");
        order2.GetPackingLabel();
        Console.WriteLine("\nShipping Label:");
        order2.GetShippingLabel();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}