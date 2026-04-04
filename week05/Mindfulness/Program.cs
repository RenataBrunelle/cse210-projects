using System;

class Program
{
    static void Main(string[] args)
    {


        string option;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breating activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            option = Console.ReadLine();


            if (option == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }


            if (option == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }


            if (option == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }



        } while (option != "4");

    }
}