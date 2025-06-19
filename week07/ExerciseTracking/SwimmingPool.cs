public class SwimmingPool : Activity
{
    private double _laps;
    private double _speed;
    private double _pace;

    //Constructor

    public SwimmingPool(string name, double distance, double duration) : base(name, distance, duration)
    {
        _speed = 60 * (distance / duration);

        _pace = duration / distance;

        _laps = distance * 1000 / 50;
    }



    //Methods

    public override void GetPace()
    {
        Console.WriteLine($"Your pace during {_name} was {_pace}min per Km");
    }

    public override void GetSpeed()
    {
        Console.WriteLine($"Your speed during {_name} was {_speed.ToString("0.0")}Kph");
    }

    public override void GetDistance()
    {
        Console.WriteLine($"The distance you swam was {_distance}Km");
    }

    public override void GetLap()
    {
        Console.WriteLine($"The number of laps completed: {_laps}");
    }

    public override string GetSumary()
    {
        string date = DateTime.Now.ToString("dd MMM yyyy");

        return $"{date} {_name},  Number of Laps: {_laps} time: ({_duration}min) - Distance {_distance}Km, Speed {_speed.ToString("0.0")}kph, Pace {_pace.ToString("0.0")} min per Km";
    }
    
}