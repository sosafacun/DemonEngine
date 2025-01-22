using Godot;
using System;
using System.Collections.Generic;

public partial class Testing : Control{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        DisplayMenu("%Elements", ".\\DemonEditor\\scenes\\resistances\\elemental_dropdown.tscn", InitData.GetElements());
        DisplayMenu("%Ailments", ".\\DemonEditor\\scenes\\resistances\\ailment_dropdown.tscn", InitData.GetAilments());
	}

    private void DisplayMenu<A>(String nodeName, String scenePath, List<A> affinities) where A : IAffinity{

        Control selectedNode = GetNode<Control>(nodeName);
        var dropdownMenu = GD.Load<PackedScene>(scenePath);
        int yPos = 36;

        foreach(A affinity in affinities)
        {
            if(affinity.IsDefault != true){
                Control new_dropdownScene = dropdownMenu.Instantiate<Control>();
                new_dropdownScene.GetNode<Label>("%Label").Text = affinity.Name;
                new_dropdownScene.Position = new Vector2(0, yPos);
                yPos += 36;
                selectedNode.AddChild(new_dropdownScene);
            }
        }
        
    }
}
