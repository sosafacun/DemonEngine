public class AilmentSkill : ISkill
{
    public int Id {get;set;}
    public string SkillName {get;set;}
    public string SkillDescription {get;set;}
    public Target Target {get;set;}
    public double HitRate {get;set;}
    public IAffinity Affinity {get;set;}
    public Stat MainStat {get;set;}
    public double StatMultiplier {get;set;}

    public AilmentSkill(int id, string skillName, string skillDescription, Target target, double hitRate, Ailment ailment, Stat mainStat, double statMultiplier)
    {
        Id = id;
        SkillName = skillName;
        SkillDescription = skillDescription;
        Target = target;
        HitRate = hitRate;
        Affinity = ailment;
        MainStat = mainStat;
        StatMultiplier = statMultiplier;
    }

    //public bool CalculateAilmentHit
}