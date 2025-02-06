using System.Collections.Generic;
using Godot;

namespace DemonEditor;

public partial class SaveData: Node{
    public static void ElementalSkill(AddSkillMenu dataContainer){
        ElementalSkill newElementalSkill = new ElementalSkill();
        List<Control> nodesToSAve = AddSkillMenu.GetNodes();
        
        GD.Print(nodesToSAve.Count);

    }

    public static void SaveToJson(){
        
    }
}