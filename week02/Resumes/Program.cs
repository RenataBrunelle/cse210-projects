using System;

public class Program
{
    static void Main(string[] args)
    {
        //Criar o objeto (usando new Job()).
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 1999;
        job1._endYear = 2020;

        //Cria a segubda instância
        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Microsoft";
        job2._startYear = 1995;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Renata";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}

//No C#, para usar uma classe, você precisa primeiro declarar ela (no arquivo Job.cs) e depois instanciar 
//(criar um objeto dela no Program.cs).