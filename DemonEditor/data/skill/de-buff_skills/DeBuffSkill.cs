using System.Collections.Generic;

namespace DemonEditor;
public class DeBuffSkill : ISkill{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Description {get;set;}
    public Target Target {get;set;}
    public double HitRate {get;set;}
    public IAffinity Affinity {get;set;}
    public List<Stat> AffectedStats {get;set;}
    public int Tier {get;set;}

    public DeBuffSkill()
    {
    }
}


/*
method to set the (de)buffs applied to selected characters (enemies or allies)
*/