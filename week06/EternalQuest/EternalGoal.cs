using System;

public class EternalGoal : Goal
{
    public EternalGoal(string _shortName, string _description, string _points) : base(_shortName, _description, _points)
    {
        
    }

    public override void RecordEvent()
    {
   
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
       return $"SimpleGoal:{_shortName},{_description},{_points},{IsComplete()}";
    }
}