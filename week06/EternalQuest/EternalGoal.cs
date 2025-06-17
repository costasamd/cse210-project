public class EternalGoal : Goal
{

    //constructor

    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {

    }

    //Methods

    public override void RecordEvent()
    {
        Console.WriteLine($"Well Done you completed a goal. You earned {GetGoalPoints}");

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:\", {GetGoalName}\", {GetGoalDescription}\", {GetGoalPoints}";
    }

    public override int GetBonus()
    {
        throw new NotImplementedException();
    }
    
}