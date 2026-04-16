using System.Diagnostics.Contracts;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetDate()
    {
        return _date.ToString("dd MM yyyy");
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string _summary = $"{GetDate()} {GetType().Name} ({_minutes} min)- Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
        return _summary;
    }
}