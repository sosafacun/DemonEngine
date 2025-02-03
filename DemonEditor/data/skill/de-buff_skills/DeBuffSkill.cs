public class DeBuffSkill : ISkill{
    public int Id {get;set;}
    public string SkillName {get;set;}
    public string SkillDescription {get;set;}
    public Target Target {get;set;}
    public double HitRate {get;set;}
    public IAffinity Affinity {get;set;}
    public int SkillBaseDamage {get;set;}
    public Stat MainStat {get;set;}

    public DeBuffSkill(int id, string skillName, string skillDescription, Target target, double hitRate, Element element)
    {
        Id = id;
        SkillName = skillName;
        SkillDescription = skillDescription;
        Target = target;
        HitRate = hitRate;
        Affinity = element;
    }
}