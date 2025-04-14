public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(string date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * (Duration / 60); // distance in miles

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed; // min per mile
}