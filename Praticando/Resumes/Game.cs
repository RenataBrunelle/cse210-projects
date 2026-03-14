using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class Game
{
    public string _title;
    public string _platform;
    public double _price;

    public void Display()
    {
        Console.WriteLine($"Jogo: {_title} | Plataforma: {_platform} | Preço: {_price}");
    } 

}