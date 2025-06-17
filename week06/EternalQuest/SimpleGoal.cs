public class SimpleGoal : Goal
{
    //Attributes
    private bool _isComplete;


    //constructor

    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {
        _isComplete = false;
    }

    //Methods

    public override void RecordEvent()
    {

        Console.WriteLine($"Well Done you completed a goal. You earned {GetGoalPoints}");
        IsComplete();

    }

    public override bool IsComplete()
    {
        return _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:\", {GetGoalName}\", {GetGoalDescription}\", {GetGoalPoints}";
    }

    public override int GetBonus()
    {
        throw new NotImplementedException();
    }
}