using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("BreathingActivity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0)
    {
        
    }

    public void Run()
    {
        int seconds = DisplayStartingMessage();     

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);

            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}