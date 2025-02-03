using System.Collections.Generic;

public class DeBuffSkill : ISkill{
    public int Id {get;set;}
    public string SkillName {get;set;}
    public string SkillDescription {get;set;}
    public Target Target {get;set;}
    public double HitRate {get;set;}
    public IAffinity Affinity {get;set;}
    public int SkillBaseDamage {get;set;}
    public List<Stat> AffectedStats {get;set;}

    public DeBuffSkill(int id, string skillName, string skillDescription, Target target, Element element, List<Stat> affectedStats)
    {
        Id = id;
        SkillName = skillName;
        SkillDescription = skillDescription;
        Target = target;
        Affinity = element;
        AffectedStats = affectedStats;
    }
}


/*
method to set the (de)buffs applied to selected characters (enemies or allies)
*/