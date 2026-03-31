using System;
using System.ComponentModel;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

public MathAssignment(string _studentName, string _topic, string text, string problem) : base(_studentName, _topic)
    {
        _textbookSection = text;
        _problems = problem;
    }


public string GetHomeworkList()
    {
        return $"Section {_textbookSection}, Problems {_problems}";
    }
}