using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Report the student's grade percentile: ");
        string infoStudent = Console.ReadLine();
        int gradeStudent = int.Parse(infoStudent);
        string grade = "";

        if (gradeStudent >= 90)
        {
            grade = "A";
        }

        else if (gradeStudent >= 80 && gradeStudent < 90)
        {
            grade = "B";
        }

        else if (gradeStudent >= 70 && gradeStudent < 80)
        {
            grade = "C";
        }

        else if (gradeStudent >= 60 && gradeStudent < 70)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        }
        Console.WriteLine($"You grade is {grade}.");
        if (gradeStudent >= 70)
        {
            Console.WriteLine($"Congratulation, you was approved !!");
        }
        else
        {
            Console.WriteLine($"You didn't pass, but you'll succeed next time !!");
        }
    }


}


//Console.WriteLine($"You grade is {gradeStudent}, Congratulation, you was approved !!");
// Console.WriteLine($"You grade is {gradeStudent}. You didn't pass, but you'll succeed next time !!");