namespace TimeTracking.Domain;

public record struct TimeKeepingRecord{
    
    public Guid Id {get; init;}

    public string Activity {get;init;}

    public DateTime StartTime {get;init;}

    public DateTime EndTime {get;init;}

    public Guid Project {get;init;}

}