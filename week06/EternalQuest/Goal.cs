using System;
using System.IO;

public abstract class Goal
{
    //attributes

    private string _shortName;
    private string _description;
    private int _points;

    //getter

    public string GetGoalName => _shortName;
    public string GetGoalDescription => _description;

    public int GetGoalPoints => _points;

    //constructors

    public Goal(string name, string description, int point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

    //Methods

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"Goal: {_shortName}, Description:{ _description}, Points worth: {_points}";
    }

    public abstract string GetStringRepresentation();

    public abstract int GetBonus();
        
}