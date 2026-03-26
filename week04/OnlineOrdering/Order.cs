using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product p in _products)
        {
            label += $"- {p.GetName()} (ID: {p.GetId()})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        string name = _customer.GetName();

        string address = _customer.GetAddress().GetFullAddress();

        return $"Shipping Label:\nName: {name}\n{address}";
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        
        double shippingRate;

        if (_customer.LiveInUSA())
        {
            shippingRate = 5;
        }

        else
        {
            shippingRate = 35;
        }

        return total + shippingRate;

    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}