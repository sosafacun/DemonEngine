namespace DemonEditor;
public class ElementalSkill: ISkill{
    public int Id {get;set;}
    public string SkillName {get;set;}
    public string SkillDescription {get;set;}
    public Target Target {get;set;}
    public double HitRate {get;set;}
    public IAffinity Affinity {get;set;}
    public int SkillBaseDamage {get;set;}
    public Stat MainStat {get;set;}
    public int NumberOfHits {get;set;}
    public double StatMultiplier {get;set;}
    public double CriticalRate {get;set;}
    public Ailment BonusEffect {get;set;}
    public int BonusEffectHitRate {get;set;}
    
    public ElementalSkill(int id, string skillName, string skillDescription, Target target, double hitRate, Element element, int numberOfHits, int skillBaseDamage, Stat mainStat, double statMultiplier, double criticalRate, Ailment bonusEffect, int bonusEffectHitRate){
        Id = id;
        SkillName = skillName;
        SkillDescription = skillDescription;
        Target = target;
        HitRate = hitRate;
        Affinity = element;
        NumberOfHits = numberOfHits;
        SkillBaseDamage = skillBaseDamage;
        MainStat = mainStat;
        StatMultiplier = statMultiplier;
        CriticalRate = criticalRate;
        BonusEffect = bonusEffect;
        BonusEffectHitRate = bonusEffectHitRate;
    }
    public int DamageFormula(){
        int damageDealt = 0;
        return damageDealt;
    }
}
    