using Godot;
using System;

public partial class ResistanceDropdown : OptionButton
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public bool isElementalDropdown = false;
	public override void _Ready()
	{
		foreach (Resistance resistance in InitData.GetResistances()){
			if(isElementalDropdown){
				GD.Print(isElementalDropdown);
				AddItem(resistance.Name);
			}
			else{
				if (resistance.AppliesToAilments){
					AddItem(resistance.Name);
				}
			}
		}
	}
}