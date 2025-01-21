public class Stat{
    public int Id {get;set;}
    public string Name {get;set;}
    public int Value {get;set;}
    public int Priority{get;set;}
    //change the description for formula
    public string Description {get;set;}

    public Stat(int id, string name, int value, int priority, string description){
        Id = id;
        Name = name;
        Value = value;
        Priority = priority;
        Description = description;
    }
}