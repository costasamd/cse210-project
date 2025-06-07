using System;

class Program
{
    static void Main(string[] args)
    {
        //Create 2 orders with 3-4 products


        //Order 1

        //cretate products 
        Product sport = new("Football", 305, 20.50, 20);
        Product sport2 = new("Sport Shirt", 255, 15.95, 60);
        Product sport3 = new("Shoes", 409, 35.99, 40);

        //create address and customer

        Address newAddress1 = new("20 west 34th st.", "New York", "NY", "USA");
        Customer customer1 = new("Trevor's Sports Hall", newAddress1);


        Order client1 = new();
        client1.AddOrderCustomer(customer1);
        client1.AddOrderProduct(sport);
        client1.AddOrderProduct(sport2);
        client1.AddOrderProduct(sport3);

        Console.WriteLine("Packing list");
        client1.Packing();
        Console.WriteLine();
        Console.WriteLine("Shipping Label");
        client1.Shipping();
        Console.WriteLine();
        //-------------------------Order 2---------------------------------------------------------  

        //Create products

        Product food1 = new("Japanese Rice", 1019, 0.50, 1500);
        Product food2 = new("Japanese Rice Vinegar", 1030, 0.80, 800);
        Product food3 = new("Japanese Panko", 1120, 0.45, 1200);
        Product food4 = new("Japanese Mochi variety", 1540, 1.05, 1000);

        //create address and customer

        Address newAddress2 = new("Av. Paulista, numero 15", "Sao Paulo", "SP", "BRA");
        Customer customer2 = new("Jhon's Convenience Store", newAddress2);

        Order client2 = new();
        client2.AddOrderCustomer(customer2);
        client2.AddOrderProduct(food1);
        client2.AddOrderProduct(food2);
        client2.AddOrderProduct(food3);
        client2.AddOrderProduct(food4);

        Console.WriteLine("Packing Label");
        client2.Packing();
        Console.WriteLine();
        Console.WriteLine("Shipping Label");
        client2.Shipping();
        Console.WriteLine();
    }
}