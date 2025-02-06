namespace DemonEditor;
public class ElementalSkill: ISkill{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Description {get;set;}
    public Target Target {get;set;}
    public double HitRate {get;set;}
    public IAffinity Affinity {get;set;}
    public int BaseDamage {get;set;}
    public Stat MainStat {get;set;}
    public int MinNumberOfHits {get;set;}
    public int MaxNumberOfHits {get;set;}
    public double StatMultiplier {get;set;}
    public double CriticalRate {get;set;}
    public Ailment BonusEffect {get;set;}
    public int BonusEffectHitRate {get;set;}
    public int Tier {get;set;}
    
    public ElementalSkill(){
    }
    public int DamageFormula(){
        int damageDealt = 0;
        return damageDealt;
    }
}
    