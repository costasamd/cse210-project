using System;
using System.Drawing;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    private int _userGoalsCompleted;

    //setter

    public void SetUserInfo(int score, int numberGoals)
    {
        _score = score;

        _userGoalsCompleted = numberGoals;
    }

    //constructor

    public GoalManager()
    {
        _score = 0;
        _userGoalsCompleted = 0;
        _goals = new();
    }

    //Methods

    public void Start()
    {
        int start = -1;

        while (start != 0)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu of option:");
            Console.WriteLine(" 1. Create new goal\n 2. List goals\n 3.Save goals\n 4. Load goals\n 5. Record Event\n 0. Quit");
            string userControl = Console.ReadLine();
            int control = int.Parse(userControl);

            if (control == 1)
            {
                CreateGoals();
            }
            else if (control == 2)
            {
                ListGoalsDetails();
            }
            else if (control == 3)
            {
                SaveGoals();
            }
            else if (control == 4)
            {
                LoadGoals();
            }
            else if (control == 5)
            {
                RecordEvent();
            }
            else if (control == 0)
            {
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your point are: {_score}");
        Console.WriteLine($"The number of goals completed are: {_userGoalsCompleted}");
    }

    public void ListGoalNames()
    {
        foreach (Goal line in _goals)
        {
            Console.WriteLine(line.GetGoalName);
        }
    }

    public void ListGoalsDetails()
    {
        Console.WriteLine($"You have {_goals.Count} goals in your list");
        foreach (Goal line in _goals)
        {
            Console.WriteLine($"{line.GetDetailsString()}");
        }
    }

    public void CreateGoals()
    {
        Console.WriteLine("Select one option form the menu below.");
        Console.WriteLine("The type of goals are:\n 1. Simple goal\n 2. Eternal goal\n 3. Checklist goal");
        string choice = Console.ReadLine();
        int userChoice = int.Parse(choice);

        if (userChoice == 1)
        {
            Console.Write("What is the name of your goal? > ");
            string name = Console.ReadLine();
            Console.Write("Give a short description of it: > ");
            string description = Console.ReadLine();
            Console.Write("How much points it is worth? > ");
            string points = Console.ReadLine();
            int userPoints = int.Parse(points);

            SimpleGoal newGoal = new(name, description, userPoints);

            _goals.Add(newGoal);


        }
        else if (userChoice == 2)
        {
            Console.Write("What is the name of your goal? > ");
            string name = Console.ReadLine();
            Console.Write("Give a short description of it: > ");
            string description = Console.ReadLine();
            Console.Write("How much points it is worth each completion? > ");
            string points = Console.ReadLine();
            int userPoints = int.Parse(points);

            EternalGoal newGoal = new(name, description, userPoints);

            _goals.Add(newGoal);
        }
        else if (userChoice == 3)
        {
            Console.Write("What is the name of your goal? > ");
            string name = Console.ReadLine();
            Console.Write("Give a short description of it: > ");
            string description = Console.ReadLine();
            Console.Write("How much points it is worth each completion? > ");
            string points = Console.ReadLine();
            int userPoints = int.Parse(points);
            Console.Write("How many times this goal need to be accomplished for a bonus? > ");
            string repeat = Console.ReadLine();
            int repeatForBonus = int.Parse(repeat);
            Console.Write("What is the bonus worth? > ");
            string bonus = Console.ReadLine();
            int bonusValue = int.Parse(bonus);

            CheckListGoal newGoal = new(name, description, userPoints, repeatForBonus, bonusValue);

            _goals.Add(newGoal);

        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("What goal did you accomplished?");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        string userComplete = Console.ReadLine();
        int userCompleted = int.Parse(userComplete);

        for (int i = 0; i < _goals.Count; i++)
        {
            if (userCompleted == (i + 1))
            {
                _goals[i].RecordEvent();
                _score += _goals[i].GetGoalPoints;
                _userGoalsCompleted += 1;

                if (_goals[i] is CheckListGoal)
                {
                    if (_goals[i].IsComplete() == true)
                    {
                        _score += _goals[i].GetBonus();
                    }
                }

                if (_goals[i].IsComplete() == true)
                {
                    _goals.Remove(_goals[i]);
                }
            }
        }
        
    }

    public void SaveGoals()
    {
        string fileName = "Goals.csv";
        string userFile = "User.csv";

        using (StreamWriter writer = new(fileName))
        {
            foreach (Goal line in _goals)
            {

                writer.WriteLine($"{line.GetStringRepresentation()}");
            }

        }
        using (StreamWriter userWriter = new(userFile))
        {
            userWriter.WriteLine($"number of points, {_score}, Number of goals completed, {_userGoalsCompleted}");
        }

    }

    public void LoadGoals()
    {
        string fileName = "goals.csv";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            if (line.Contains("SimpleGoal"))
            {
                string[] parts = line.Split("\",");
                //example: SimpleGoal:", jump rope", 3 min", 30

                string name = parts[1];
                string description = parts[2];
                string point = parts[3];
                int points = int.Parse(point);

                SimpleGoal recoverGoals = new(name, description, points);

                _goals.Add(recoverGoals);
            }
            else if (line.Contains("EternalGoal"))
            {
                string[] parts = line.Split("\",");
                //example: EternalGoal:", read book", 10 min", 30

                string name = parts[1];
                string description = parts[2];
                string point = parts[3];
                int points = int.Parse(point);

                EternalGoal recoverGoals = new(name, description, points);

                _goals.Add(recoverGoals);
            }
            else if (line.Contains("CheckListGoal"))
            {
                string[] parts = line.Split("\",");
                //example: CheckListGoal:", push ups", 30 per day", 30", 300", 7", 1

                string name = parts[1];
                string description = parts[2];
                string point = parts[3];
                int points = int.Parse(point);
                string bonus = parts[4];
                int yourbonus = int.Parse(bonus);
                string target = parts[5];
                int yourTarget = int.Parse(target);
                string done = parts[6];
                int youDoneIt = int.Parse(done);

                CheckListGoal recoverGoals = new(name, description, points, yourTarget, yourbonus, youDoneIt);

                _goals.Add(recoverGoals);
            }
        }

        string userFile = "User.csv";

        string[] userInfo = System.IO.File.ReadAllLines(userFile);

        foreach (string info in userInfo)
        {
            string[] data = info.Split(",");

            //data look like this: 
            //number of points, 130, Number of goals completed, 2

            //data[1] user points 
            //data[4] number of goals completed

            string strUserPoints = data[1];
            int userPoints = int.Parse(strUserPoints);
            string strUserGoals = data[3];
            int userGoalsCompleted = int.Parse(strUserGoals);

            SetUserInfo(userPoints, userGoalsCompleted);
        }
         
    }
}