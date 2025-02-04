namespace DemonEditor;
public class Target: IData{
    public int Id {get;set;}
    public string Name {get;set;}
    public Target(int idTarget, string targetName){
        Id = idTarget;
        Name = targetName;
    }
}