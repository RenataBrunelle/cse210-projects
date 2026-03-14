using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class Education
{
    public string _school;
    public string _degree;
    public int _graduationYear;

    public void Display()
    {
        Console.WriteLine($"{_degree} ({_school}) - {_graduationYear}");
    }
}