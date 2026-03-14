using System;

class Entry
{
    public string _date;
    public string _response;
    public string _promptText;

    public void Display()
    {
        Console.WriteLine($"{_promptText} and the response: {_response} in {_date}");
    }
}