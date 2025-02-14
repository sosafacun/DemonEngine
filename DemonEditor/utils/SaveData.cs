using System;
using System.Collections.Generic;
using Godot;

namespace DemonEditor;

public partial class SaveData: Node{
    private AddSkillMenu _SkillMenu;
    public SaveData(AddSkillMenu addSkillMenu){
        _SkillMenu = addSkillMenu;
    }

    public void ElementalSkill(){
        GD.Print(_SkillMenu.GetChildren());
        ElementalSkill newElementalSkill = new ElementalSkill();

        newElementalSkill.Name = GetEditableLineText("%SkillName");
        newElementalSkill.Tier = int.Parse(GetEditableLineText("%SkillTier"));
        newElementalSkill.HitRate = int.Parse(GetEditableLineText("./TabContainer/AddSkillMenu/SkillMenu/AddElementalSkill/HitRate"));
        newElementalSkill.BaseDamage = int.Parse(GetEditableLineText("%BaseDamage"));
        newElementalSkill.MinNumberOfHits = int.Parse(GetEditableLineText("%MinNumberOfHits"));
        newElementalSkill.MaxNumberOfHits = int.Parse(GetEditableLineText("%MaxNumberOfHits"));
        newElementalSkill.StatMultiplier = double.Parse(GetEditableLineText("%StatMultiplier"));
        newElementalSkill.CriticalRate = int.Parse(GetEditableLineText("%CriticalRate"));

        SaveToJson();
    }

    private static void SaveToJson(){
        
    }

    private string GetEditableLineText(string uniqueName){
        EditableLine selectedNode = _SkillMenu.GetNode<EditableLine>(uniqueName);
        return selectedNode.GetNode<LineEdit>("%EditableLineEdit").Text;
    }
}