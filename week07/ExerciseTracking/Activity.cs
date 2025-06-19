public abstract class Activity
{
    protected string _name;
    protected double _distance;
    protected double _duration;

    //Constructor

    public Activity(string name, double distance, double duration)
    {
        _name = name;
        _distance = distance;
        _duration = duration;
    }

    //Methods

    public abstract string GetSumary();

    public abstract void GetSpeed();

    public abstract void GetPace();

    public abstract void GetDistance();

    public abstract void GetLap();

}