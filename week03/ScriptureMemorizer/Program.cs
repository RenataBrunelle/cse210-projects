using System;
//If the user types "show", it displays the entire script text.
class Program
{
    static void Main(string[] args)
    {
        Reference _reference = new Reference("Provérbios", 3, 5);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding.";
        Scripture scripture = new Scripture(_reference, text);

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Press Enter to hide or type 'quit' if you want to exit, finally, if you want to show all the text, type 'show': ");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                break;
            }
            else if (userInput == "show")
            {
                scripture.ShowAllWords();
            }
            else
            {
                scripture.HiderRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Program closed");
    }
}

