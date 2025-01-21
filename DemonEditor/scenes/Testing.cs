using Godot;
using System;

public partial class Testing : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var elementalDropdownMenu = GD.Load<PackedScene>(".\\DemonEditor\\scenes\\element_picker\\elemental_dropdown.tscn");
		int yPos = 36;

		foreach(Element element in InitData.GetElements())
        {
            if(element.IsDefault != true){
                Control new_dropdownScene = elementalDropdownMenu.Instantiate<Control>();
                new_dropdownScene.GetNode<Label>("%ElementalLabel").Text = element.Name;
                new_dropdownScene.Position = new Vector2(0, yPos);
                yPos += 36;
                AddChild(new_dropdownScene);
            }
        }
	}
}
