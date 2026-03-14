using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGeneration promptGen = new PromptGeneration();
        string info;
        do
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Clear Journal");
            Console.WriteLine("6. Quit");

            info = Console.ReadLine();


            if (info == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);

                string userResponse = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();


                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._response = userResponse;

                theJournal.AddEntry(newEntry);

            }
            else if (info == "2")
            {
                theJournal.DisplayAll();
            }
            else if (info == "3")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
            else if (info == "4")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);

            }
            else if (info == "5")
            {
                
            }


        } while (info != "6");

        Console.WriteLine("Goodbye!");

    }
}