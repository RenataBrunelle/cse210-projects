using System;

public class Product
{
    private int _idProduct;
    private string _nameProduct;
    private double _price;
    private int _qtyProduct;

    public Product(int id, string name, double price, int qty)
    {
        _idProduct = id;
        _nameProduct = name;
        _price = price;
        _qtyProduct = qty;
    }

    public double GetTotalCost()
    { 
        return _price * _qtyProduct;
    }

    public string GetName() {return _nameProduct;}
    public int GetId() {return _idProduct;}

    public void SetPrice(double price) {_price = price;}
    public void SetQty(int qty) {_qtyProduct = qty;}

}