using System;
using System.Data;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");

        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        return seconds;
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int seconds)
    {
      List<string> animationCharacters = new List<string> { "|", "/", "-", "\\" };
    
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;

    while (DateTime.Now < endTime)
    {
        string s = animationCharacters[i];
        Console.Write(s);
        Thread.Sleep(250); 
        Console.Write("\b \b");

        i++;

        if (i >= animationCharacters.Count)
        {
            i = 0; 
        }
    }  
    }

    
}
