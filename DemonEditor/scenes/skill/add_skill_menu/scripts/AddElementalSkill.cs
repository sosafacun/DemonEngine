using Godot;
using System;

public partial class AddElementalSkill : Control
{
	//Get the dropdown where the elements will be displayed
	private OptionButton ElementalDropdown;

	//Get the dropdown where the stats will be displayed
	private OptionButton StatDropdown;
	public override void _Ready()
	{
		ElementalDropdown = GetNode<OptionButton>("%ElementDropdown");
		InitData.PopulateAffinityDropdown<Element>(ElementalDropdown, InitData.elements);

		StatDropdown = GetNode<OptionButton>("%StatDropdown");
		InitData.PopulateNormalDropdown<Stat>(StatDropdown, InitData.stats);
	}

	//This will be used to expand the elemental skill creator menu to include an ailment to that skill.
	private void AppliesAilmentSelected(bool toggled){
		GD.Print("Toggled Bonus Ailment.");
	}
}
