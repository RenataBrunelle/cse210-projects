using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(bool isComplete,string _shortName, string _description, string _points) : base (_shortName,_description,_points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
       return $"SimpleGoal:{_shortName},{_description},{_points},{IsComplete()}";
    }
}