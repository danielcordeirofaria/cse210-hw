using System;

class Program
{
    static void Main(string[] args){
        Address address1 = new Address("Rua dos Limoeiros, 420", "Rio de Janeiro", "Rio de Janeiro State", "Brazil");
        Address address2 = new Address("1600 Pennsylvania Avenue NW", "Washington", "DC", "USA");

        Customer danielFaria = new Customer("Daniel Faria", address1);
        Customer joeBiden = new Customer("Joe Biden", address2);

        Product product1 = new Product("PlayStation 5 Console (PS5)", "1.1", 499.99m, 1);
        Product product2 = new Product("Sony PlayStation Dualsense Wireless Controller - PlayStation 5", "2.1", 89.99m, 2);
        Product product3 = new Product("FIFA 23 Standard Edition Playstation 5 (PS5)| English | Import Region Free", "3.1", 47.90m, 1);

        Product product4 = new Product("PFFY 2 Packs Baseball Cap Golf Dad Hat for Men and Women", "1.2", 15.25m, 1);
        Product product5 = new Product("HONEYBULL Walking Cane for Men & Women", "2.2", 27.99m, 1);


        List<Product> order1List = new List<Product>() { product1, product2, product3 };
        Order order1 = new Order(order1List, danielFaria);

        List<Product> order2List = new List<Product>() { product4, product5 };
        Order order2 = new Order(order2List, joeBiden);

        decimal totalCost1 = order1.TotalCost();
        decimal totalCost2 = order2.TotalCost();

        string packingLabel1 = order1.PackingLabel();
        string packingLabel2 = order2.PackingLabel();

        string shippingLabel1 = order1.ShippingLabel();
        string shippingLabel2 = order2.ShippingLabel();

        Console.WriteLine("Order 1:");
        Console.WriteLine(packingLabel1);
        Console.WriteLine(shippingLabel1);
        Console.WriteLine("Total Cost: $" + totalCost1);
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(packingLabel2);
        Console.WriteLine(shippingLabel2);
        Console.WriteLine("Total Cost: $" + totalCost2);
    }
}