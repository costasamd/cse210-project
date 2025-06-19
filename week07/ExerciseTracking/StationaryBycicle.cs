public class StationaryBycicle : Activity
{
    private double _speed;
    private double _pace;

    //Constructor

    public StationaryBycicle(string name, double distance, double duration) : base(name, distance, duration)
    {
        _speed = 60 * (distance / duration);

        _pace = duration / distance;
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
        Console.WriteLine($"The distance you rode was {_distance}Km");
    }

    public override string GetSumary()
    {
        string date = DateTime.Now.ToString("dd MMM yyyy");

        return $"{date} {_name} ({_duration}) - Distance {_distance}Km, Speed {_speed.ToString("0.0")}kph, Pace {_pace} min per Km";
    }
    public override void GetLap()
    {
        throw new NotImplementedException();
    }

}