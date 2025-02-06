using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemonEditor;

public partial class AddElementalSkill : Control
{
	//Get the dropdown where the elements will be displayed
	private OptionButton ElementalDropdown;

	//Get the dropdown where the stats will be displayed
	private OptionButton StatDropdown;
	private readonly string BonusEffectPath = "./DemonEditor/scenes/skill/add_skill_menu/bonus_effect_on_elemental_skill.tscn";
	public override void _Ready()
	{
		ElementalDropdown = GetNode<OptionButton>("%ElementDropdown");
		GlobalMethods.PopulateAffinityDropdown(ElementalDropdown, InitData.elements);

		StatDropdown = GetNode<OptionButton>("%StatDropdown");
		GlobalMethods.PopulateNormalDropdown(StatDropdown, InitData.stats);
	}

	//This expands the elemental skill to have an ailment when the checkbox is toggled.
	private void AppliesAilmentSelected(bool toggled){
		if(toggled){
			var packedScene = GD.Load<PackedScene>(BonusEffectPath);
			Control bonusEffectMenu = packedScene.Instantiate<Control>();

			GetParent<Control>().AddChild(bonusEffectMenu);

			bonusEffectMenu.Position = new Vector2(704, 0);
		}
		if (!toggled){
			Control bonusEffectMenu = GetParent<Control>().GetNode<Control>("./BonusEffectOnSkill");
			bonusEffectMenu.QueueFree();
		}
	}
}
