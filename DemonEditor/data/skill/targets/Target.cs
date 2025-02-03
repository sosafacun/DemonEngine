public class Target{
    private int _IdTarget {get;set;}
    private string _TargetName {get;set;}

    public int IdTarget{
        get => _IdTarget;
    }
    public string TargetName {
        get => _TargetName;
    }

    public Target(int idTarget, string targetName){
        _IdTarget = idTarget;
        _TargetName = targetName;
    }
}