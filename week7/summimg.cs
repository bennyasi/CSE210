public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0; // distance in kilometers

    public override double GetSpeed() => (GetDistance() / Duration) * 60; // kph

    public override double GetPace() => Duration / GetDistance(); // min per km
}