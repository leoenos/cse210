using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("3 This St", "Parker", "CO", "US");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Switch 2", "ID001", 450, 1));
        order1.AddProduct(new Product("Games", "ID002", 60, 4));

        Address address2 = new Address("3 That Rd", "Lethbridge", "Alberta", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("BTS Album Arirang", "ID007", 25, 8));
        order2.AddProduct(new Product("Vinyl Record Player", "ID003", 150, 1));
        order2.AddProduct(new Product("Display Shelves", "ID004", 50, 4));

        Display(order1);
        Console.WriteLine("_________________________");
        Display(order2);

    static void Display(Order order)
        {
            Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}");

            Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel}");

            Console.WriteLine($"Total: ${order.CalculateTotal():0.00}");
        }
    }
}