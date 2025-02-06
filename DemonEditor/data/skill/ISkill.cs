namespace DemonEditor;
public interface ISkill{
    int Id {get;set;}
    string Name {get;set;}
    string Description {get;set;}
    Target Target {get;set;}
    IAffinity Affinity {get;set;}
    int Tier {get;set;}
}
