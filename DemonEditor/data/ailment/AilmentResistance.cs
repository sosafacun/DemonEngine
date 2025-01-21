public class AilmentResistance
{
    public Ailment Ailment { get; set; }
    public Resistance Resistance { get; set; }

    public AilmentResistance(Ailment ailment, Resistance resistance)
    {
        Ailment = ailment;
        Resistance = resistance;
    }

    public AilmentResistance()
    {
    }

    public void SetAilment(Ailment ailment){
        Ailment = ailment;
    }

    public void SetResistance(Resistance resistance){
        Resistance = resistance;
    }
}