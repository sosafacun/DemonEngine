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
    
    public ElementalSkill(int id, string skillName, string skillDescription, Target target, double hitRate, Element element, int numberOfHits, int skillBaseDamage, Stat mainStat, double statMultiplier){
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
    }


    public int DamageFormula(/*List<Demon> selectedDemons*/){
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
}