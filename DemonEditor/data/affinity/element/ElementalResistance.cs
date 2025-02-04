namespace DemonEditor;
public class ElementalResistance
{
    public Element Element { get; set; }
    public Resistance Resistance { get; set; }

    public ElementalResistance(Element element, Resistance resistance)
    {
        Element = element;
        Resistance = resistance;
    }
    
    public ElementalResistance(){}

    public void SetElement(Element element){
        Element = element;
    }
    public void SetResistance(Resistance resistance){
        Resistance = resistance;
    }


}
