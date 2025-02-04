namespace DemonEditor;
public class Ailment : IAffinity
{
    public int Id {get; set;}

    public string Name {get; set;}

    public bool IsDefault {get; set;}

    public string Description {get;set;}
    public bool LastsAfterBattle {get;set;}

}
