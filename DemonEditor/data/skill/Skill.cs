public class Skill{

    //Constructor for elemental attacks
    public Skill(int id, string skillName, string skillDescription, bool isElemental, Target target, double hitRate, IAffinity affinity, int numberOfHits, int skillBaseDamage, Stat mainStat, float effectMultiplier)
    {
        _Id = id;
        _SkillName = skillName;
        _SkillDescription = skillDescription;
        _IsElemental = isElemental;
        _Target = target;
        _HitRate = hitRate;
        _Affinity = affinity;
        _NumberOfHits = numberOfHits;
        _SkillBaseDamage = skillBaseDamage;
        _MainStat = mainStat;
        _EffectMultiplier = effectMultiplier;
    }
    //Constructor for ailment attacks
    public Skill(int id, string skillName, string skillDescription, bool isElemental, Target target, double hitRate, IAffinity affinity, int numberOfHits, Stat mainStat, float effectMultiplier)
    {
        _Id = id;
        _SkillName = skillName;
        _SkillDescription = skillDescription;
        _IsElemental = isElemental;
        _Target = target;
        _HitRate = hitRate;
        _Affinity = affinity;
        _NumberOfHits = numberOfHits;
        _MainStat = mainStat;
        _EffectMultiplier = effectMultiplier;
    }
    //Constructor for (de)buffs
    public Skill(int id, string skillName, string skillDescription, bool isElemental, Target target, double hitRate, IAffinity affinity, int numberOfHits, Stat mainStat)
    {
        _Id = id;
        _SkillName = skillName;
        _SkillDescription = skillDescription;
        _IsElemental = isElemental;
        _Target = target;
        _HitRate = hitRate;
        _Affinity = affinity;
        _NumberOfHits = numberOfHits;
        _MainStat = mainStat;
    }
    
    private int _Id {get;set;}
    private string _SkillName {get;set;}
    private string _SkillDescription {get;set;}
    private bool _IsElemental {get;set;}
    private Target _Target {get;set;}
    private double _HitRate {get;set;}
    private IAffinity _Affinity {get;set;}
    private int _NumberOfHits {get;set;}
    private int _SkillBaseDamage {get;set;}
    private Stat _MainStat {get;set;}
    private float _EffectMultiplier {get;set;}

    public int id{
        get => _Id;
        set => _Id = value;
    }
    public string skillName{
        get => _SkillName;
        set => _SkillName = value;
    }
    public string skillDescription{
        get => _SkillDescription;
        set => _SkillDescription = value;
    }
    public bool isElemental{
        get => _IsElemental;
        set => _IsElemental = value;
    }
    public Target target{
        get => _Target;
        set => _Target = value;
    }
    public double hitRate{
        get => _HitRate;
        set => _HitRate = value;
    }
    public IAffinity affinity{
        get => _Affinity;
        set => _Affinity = value;
    }
    public int numberOfHits{
        get => _NumberOfHits;
        set => _NumberOfHits = value;
    }
    public int skillBaseDamage{
        get => _SkillBaseDamage;
        set => _SkillBaseDamage = value;
    }
    public Stat mainStat {
        get => _MainStat;
        set => _MainStat = value;
    }
    public float effectMultiplier{
        get => _EffectMultiplier;
        set => _EffectMultiplier = value;
    }
    
    
    public int DamageFormula(/*Demon selectedDemon OR Demon selectedDemons (for multiple selected targets)*/){
        int damageDealt = 0;
        float resistanceMultiplier;
        float statMultiplier;
        float attackerMultiplier;
        Element demonAffinity;
        /*

        demonAffinity = InitData.elements.Find(e => e.Name == Skill.skillName);

        switch(demonAffinity.Resistance.Id){
            case 1: //DEFAULT resistance
                resistanceMultiplier = 1;
            case 2: //RES resistance
                resistanceMultiplier = 0.5;
            case 3: //WK resistance
                resistanceMultiplier = 1.5;
            case 4: //NULL resistance
                resistanceMultiplier = 0;
            case 5: //RPL resistance
                resistanceMultiplier = 0;
            case 6: //DR resistance
                resistanceMultiplier = -1;
        }

        statMultiplier = selectedDemon.Stats.Find(s => s.Name == "VIT"); //parse to float
        resistanceMultiplier + = statMultiplier;

        attackerMultiplier = attackerDemon.Stat.Find(s => S.Name == mainStat.Name).Get.statValue;
        attackerMultiplier = attackerMultiplier * effectMultiplier;
        damageDealt = (skillBaseDamage * attackerMultiplier) *resistanceMultiplier
        */
        return damageDealt;
    }
    public bool AilmentCalculation(/*Demon selectedDemon OR Demon selectedDemons (for multiple selected targets)*/){
        bool targetGetsAffected = false;
        /*foreach Demon in selectedDemons...*/
        return targetGetsAffected;
    }
}