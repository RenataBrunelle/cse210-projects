using System;
using System.Collections.Generic;
using System.Data;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
       "Who are people that you appreciate?",
       "What are personal strengths of yours?",
       "Who are people that you have helped this week?",
       "When have you felt the Holy Ghost this month?",
       "Who are some of your personal heroes?"
        
    };
        

    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _count = 0;
    }
    

    public string GetRandomPrompt()
    {
        Random randomGenaration = new Random();
        int index = randomGenaration.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
        _duration = DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n --- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        _count = 0;
        Console.WriteLine("Start listing items (press Enter after each one):");
        GetListFromUser();

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();

    }

    public void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

  
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(entry))
            {
                _count++;
            }
        } 
    }

}