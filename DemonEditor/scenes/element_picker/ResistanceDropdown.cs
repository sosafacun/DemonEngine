using Godot;
using System;

public partial class ResistanceDropdown : OptionButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		foreach (Resistance resistance in InitData.GetResistances()){
			AddItem(resistance.Name);
		}
	}
}
