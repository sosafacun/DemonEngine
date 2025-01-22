using Godot;
using System;
using System.Collections.Generic;

public partial class Testing : Control{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        DisplayMenu("%Elements", ".\\DemonEditor\\scenes\\resistances\\elemental_dropdown.tscn", InitData.elements);
        DisplayMenu("%Ailments", ".\\DemonEditor\\scenes\\resistances\\ailment_dropdown.tscn", InitData.ailments);
	}

    //nodeName = node where the dropdowns and labels will be stored
    //scenePath = scene where the dropdown and label scene are stored. This will create the current aviable ailments / elements (useful for when CRUD is implemented)
    //List<A> any list with the Affinity Interface implementation = Element and Ailment classes have it.
    private void DisplayMenu<A>(String nodeName, String scenePath, List<A> affinities) where A : IAffinity{
        //Since there are only 2 columns (elements and ailments), this takes care of both
        Control selectedNode = GetNode<Control>(nodeName);
        var dropdownMenu = GD.Load<PackedScene>(scenePath);
        //initial position
        int yPos = 36;

        foreach(A affinity in affinities)
        {
            if(affinity.IsDefault != true){
                Control new_dropdownScene = dropdownMenu.Instantiate<Control>();
                //set the label text to the name of the element / ailment
                new_dropdownScene.GetNode<Label>("%Label").Text = affinity.Name;

                //add spacing for the following dropdown menu
                new_dropdownScene.Position = new Vector2(0, yPos);
                yPos += 36;

                selectedNode.AddChild(new_dropdownScene);
            }
        }
        
    }
}
