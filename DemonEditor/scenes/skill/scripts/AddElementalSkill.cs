using Godot;
using System;

public partial class AddElementalSkill : Control
{
	//Get the dropdown where the elements will be displayed
	private OptionButton ElementalDropdown;

	//Get the dropdown where the stats will be displayed
	private OptionButton StatDropdown;
	private string BonusEffectPath = "./DemonEditor/scenes/skill/bonus_effect_on_skill.tscn";
	public override void _Ready()
	{
		ElementalDropdown = GetNode<OptionButton>("%ElementDropdown");
		InitData.PopulateAffinityDropdown<Element>(ElementalDropdown, InitData.elements);

		StatDropdown = GetNode<OptionButton>("%StatDropdown");
		InitData.PopulateNormalDropdown<Stat>(StatDropdown, InitData.stats);
	}

	//This will be used to expand the elemental skill creator menu to include an ailment to that skill.
	private void AppliesAilmentSelected(bool toggled){
		if(toggled){
			var packedScene = GD.Load<PackedScene>(BonusEffectPath);
			Control bonusEffectMenu = packedScene.Instantiate<Control>();

			GetParent<Control>().AddChild(bonusEffectMenu);

			bonusEffectMenu.Position = new Vector2(704, 0);
		}
	}
}
