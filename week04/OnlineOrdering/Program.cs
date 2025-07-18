using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Products
        // Product 1
        Product product1 = new Product();
        product1.SetName("Cookies");
        product1.SetPrice(2.50);
        product1.SetID(1246);

        // Product 2
        Product product2 = new Product();
        product2.SetName("Chips");
        product2.SetPrice(1.50);
        product2.SetID(3571);

        // Product 3
        Product product3 = new Product();
        product3.SetName("Soda");
        product3.SetPrice(3.50);
        product3.SetID(7452);

        // Create Customers
        Customer customer1 = new Customer();
        customer1.SetName("Joe Hendry");
        Customer customer2 = new Customer();
        customer2.SetName("Case Smith");

        // Create Address
        Address address1 = new Address();
        Address address2 = new Address();
        address1.SetStreetAddress("1234 Main Street");
        address1.SetCity("Phoenix");
        address1.SetStateOrProvince("Arizona");
        address1.SetCountry("USA");
        address2.SetStreetAddress("5678 Corner Road");
        address2.SetCity("Malton");
        address2.SetStateOrProvince("Ontario");
        address2.SetCountry("Canada");

        // Order 1
        Console.WriteLine(customer1.GetName());
        Console.WriteLine(address1.DisplayAddress());

        Console.WriteLine();

        // Order 2
        Console.WriteLine(customer2.GetName());
        Console.WriteLine(address2.DisplayAddress());
    }
}