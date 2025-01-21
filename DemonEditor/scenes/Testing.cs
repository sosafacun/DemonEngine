using Godot;
using System;

public partial class Testing : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		DisplayElementalResistances();
		DisplayAilmentResistances();
	}

	private void DisplayElementalResistances(){
		Control elementalNode = GetNode<Control>("%Elements");
		var elementalDropdownMenu = GD.Load<PackedScene>(".\\DemonEditor\\scenes\\resistances\\elemental_dropdown.tscn");
		int yPos = 36;

		foreach(Element element in InitData.GetElements())
        {
            if(element.IsDefault != true){
                Control new_dropdownScene = elementalDropdownMenu.Instantiate<Control>();
                new_dropdownScene.GetNode<Label>("%ElementalLabel").Text = element.Name;
                new_dropdownScene.Position = new Vector2(0, yPos);
                yPos += 36;
                elementalNode.AddChild(new_dropdownScene);
            }
        }
	}

	private void DisplayAilmentResistances(){
		Control ailmentNode = GetNode<Control>("%Ailments");
		var ailmentDropdownMenu = GD.Load<PackedScene>(".\\DemonEditor\\scenes\\resistances\\ailment_dropdown.tscn");
		int yPos = 36;

		foreach(Ailment ailment in InitData.GetAilments())
        {
            if(ailment.IsDefault != true){
                Control new_dropdownScene = ailmentDropdownMenu.Instantiate<Control>();
                new_dropdownScene.GetNode<Label>("%AilmentLabel").Text = ailment.Name;
                new_dropdownScene.Position = new Vector2(0, yPos);
                yPos += 36;
                ailmentNode.AddChild(new_dropdownScene);
            }
        }
	}
}
