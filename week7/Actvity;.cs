using System;

public abstract class Activity
{
    private string _date;
    private double _duration; // in minutes

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    protected double Duration => _duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min): Distance {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2} min/unit";
    }
}