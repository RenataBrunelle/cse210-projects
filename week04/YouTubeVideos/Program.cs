using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Video _video01 = new Video("Funny", "Mary", 100);
        Comment _comment01 = new Comment("Jonh","This video is very funny");
        Comment _comment02 = new Comment("Peter", "I love this video");
        Comment _comment03 = new Comment("Robert", "I don't get to stop watching this video.");

        _video01.AddComment(_comment01);
        _video01.AddComment(_comment02);
        _video01.AddComment(_comment03);

        _video01.DisplayVideoInfo();

        Video _video02 = new Video("Trees", "Melissa", 101);
        Comment _comment04 = new Comment("Victor", "It's a beautiful video");
        Comment _comment05 = new Comment("Joseph", "I loved this video.");
        Comment _comment06 = new Comment("Hanna", "I needed to watch this video");

        _video02.AddComment(_comment04);
        _video02.AddComment(_comment05);
        _video02.AddComment(_comment06);

        _video02.DisplayVideoInfo();

        Video _video03 = new Video("Cars", "Joseph",150);
        Comment _comment07 = new Comment("Michael", "Wow !!!!!!!!!!!!!!!");
        Comment _comment08 = new Comment("Sidney", "INCREDIBLE !!!!!!!!");
        Comment _comment09 = new Comment("Mary", "I loved this video.");

        _video03.AddComment(_comment07);
        _video03.AddComment(_comment08);
        _video03.AddComment(_comment09);

        _video03.DisplayVideoInfo();

    }
}
