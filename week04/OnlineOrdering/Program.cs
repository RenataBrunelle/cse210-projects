using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 01
        Address address01 = new Address("Street A", "Caxias do Sul", "RS", "Brazil");
        Customer cust01 = new Customer("Renata", address01);

        Order order01 = new Order(cust01);
        
        Product p1 = new Product(1, "Portable", 1000.00, 1);
        order01.AddProduct(p1);

        Product p2 = new Product(2, "Keyborad", 10.00, 1);
        order01.AddProduct(p2);

        //Order 02
        Address address02 = new Address("Street B", "Caxias do Sul", "RS", "Brazil");
        Customer cust02 = new Customer("Bianca", address02);

        Order order02 = new Order(cust02);

        Product p3 = new Product(3, "Mouse", 5.00, 2);
        order02.AddProduct(p3);

        Product p4 = new Product(4, "Key", 1.00, 5);
        order02.AddProduct(p4);

        List<Order> orders = new List<Order> {order01, order02};

        foreach (Order o in orders)
        {
            Console.WriteLine(o.PackingLabel());
            Console.WriteLine(o.ShippingLabel());
            Console.WriteLine($"Total Order Cost: ${o.CalculateTotal()}");

        }



    }
}