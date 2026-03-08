using System;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(name, squaredNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter the username");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter the favorite number");
        string favorite = Console.ReadLine();
        int favoriteNumber = int.Parse(favorite);
        return favoriteNumber;
    }
    static int SquareNumber(int number)
    {
        int numberMod = number * number;
        return numberMod;
    }
    static void DisplayResult(string userName, int number)
    {
        Console.WriteLine($"{userName}, the square of your number is {number}");

    }

}