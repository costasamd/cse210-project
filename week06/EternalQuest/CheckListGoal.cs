public class CheckListGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    private int _bonusConceded = 0;

    //constructor

    public CheckListGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _bonus = bonus;
        _target = target;
        _amountComplete = 0;

    }

    public CheckListGoal(string name, string description, int point, int target, int bonus, int amount) : base(name, description, point)
    {
        _bonus = bonus;
        _target = target;
        _amountComplete = amount;

    }

    //Methods

    public override void RecordEvent()
    {
        Console.WriteLine($"Well done you completed your goal. You earned {GetGoalPoints}");
        _amountComplete += 1;

        if (_amountComplete == (_target - 1))
        {
            Console.WriteLine("Well Done so far, you are 1 step away to get your bonus.");
            Console.WriteLine($"Keep working hard. next time you will get {_bonus} bonus points");
        }

    }

    public override bool IsComplete()
    {
        if (_amountComplete != _target)
        {
            return false;
        }
        else if (_amountComplete == _target)
        {
            return true;
        }

        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:\", {GetGoalName}\", {GetGoalDescription}\", {GetGoalPoints}\", {_bonus}\", {_target}\", {_amountComplete}";
    }

    public override string GetDetailsString()
    {
        return $"Goal:{GetGoalName}, Description{GetGoalDescription}, Points worth{GetGoalPoints}, Bonus for completion:{_bonus}, Number to complete: {_target}, completed:{_amountComplete}/{_target}";
    }

    public override int GetBonus()
    {
        if (IsComplete() == true)
        {
            _bonusConceded = _bonus;
        }

        return _bonusConceded;
    }
 }