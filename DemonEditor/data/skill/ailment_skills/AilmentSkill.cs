namespace DemonEditor;
public class AilmentSkill : ISkill
{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Description {get;set;}
    public Target Target {get;set;}
    public double HitRate {get;set;}
    public IAffinity Affinity {get;set;}
    public Stat MainStat {get;set;}
    public double StatMultiplier {get;set;}
    public int Tier {get;set;}

    public AilmentSkill()
    {
    }

    //public bool CalculateAilmentHit
}