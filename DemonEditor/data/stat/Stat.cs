using System.Windows.Markup;

public class Stat{
    public int Id {get;set;}
    public string Name {get;set;}
    private int _StatValue {get;set;}
    public int Priority{get;set;}
    //change the description for formula
    public string Description {get;set;}

    public int statValue{
        get => _StatValue;
        set => _StatValue = value;
    }
    
    public Stat(int id, string name, int value, int priority, string description){
        Id = id;
        Name = name;
        _StatValue = value;
        Priority = priority;
        Description = description;
    }
}