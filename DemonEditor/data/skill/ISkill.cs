public interface ISkill{
    int Id {get;set;}
    string SkillName {get;set;}
    string SkillDescription {get;set;}
    Target Target {get;set;}
    double HitRate {get;set;}
    IAffinity Affinity {get;set;}
    int SkillBaseDamage {get;set;}
}
