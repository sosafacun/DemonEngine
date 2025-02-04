using Godot;
using System;

namespace DemonEditor;
public partial class ResistanceDropdown : OptionButton
{
	//Used to determine if the info is an ailment or an element
	[Export]
	public bool isElementalDropdown;
	public override void _Ready()
	{
		foreach (Resistance resistance in InitData.resistances){
			if(isElementalDropdown){
				AddItem(resistance.Name);
			}
			else{
				//If the item is not an element, is al ailment. so DR (drain) and RPL (repel) can't be resistances
				if (resistance.AppliesToAilments){
					AddItem(resistance.Name);
				}
			}
		}
	}
}