using Godot;
using System;
using System.Collections.Generic;
namespace DemonEditor;

public partial class Testing : Control{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        DisplayMenu("%Elements", "./DemonEditor/scenes/resistances/elemental_dropdown.tscn", InitData.elements);
        DisplayMenu("%Ailments", "./DemonEditor/scenes/resistances/ailment_dropdown.tscn", InitData.ailments);
        PopulateEditMenus("%ElementEditor", InitData.elements, true);
        PopulateEditMenus("%AilmentEditor", InitData.ailments, false);
	}

    //nodeName = node where the dropdowns and labels will be stored
    //scenePath = scene where the dropdown and label scene are stored. This will create the current aviable ailments / elements (useful for when CRUD is implemented)
    //List<A> any list with the Affinity Interface implementation = Element and Ailment classes have it.
    private void DisplayMenu<A>(String nodeName, String scenePath, List<A> affinities) where A : IAffinity{
        //Since there are only 2 columns (elements and ailments), this takes care of both
        Control selectedNode = GetNode<Control>(nodeName);
        var dropdownMenu = GD.Load<PackedScene>(scenePath);
        //initial position
        int yPos = 50;

        foreach(A affinity in affinities){
            if(affinity.IsDefault){
                Control new_dropdownScene = dropdownMenu.Instantiate<Control>();
                //set the label text to the name of the element / ailment
                new_dropdownScene.GetNode<Label>("%Label").Text = affinity.Name;

                //add spacing for the following dropdown menu
                new_dropdownScene.Position = new Vector2(0, yPos);
                yPos += 50;

                selectedNode.AddChild(new_dropdownScene);
            }
        }
        
    }

    //This piece of code will be used for the Demon Creation Menu. It will list all of the selectable elements and ailments.
    private void PopulateEditMenus<A>(string tabName, List<A> affinities, bool isElemental) where A: IAffinity{
        Control selectedNode = GetNode<Control>(tabName);
        var editTemplate = GD.Load<PackedScene>("./DemonEditor/scenes/affinity_editor/affinity_editor.tscn");

        int yPos = 50;

        foreach(A affinity in affinities){
            AffinityEditor new_EditScene = editTemplate.Instantiate<AffinityEditor>();
            new_EditScene.GetNode<Label>("%Label").Text = affinity.Name;

            new_EditScene.Position = new Vector2(0, yPos);
            yPos += 50;

            new_EditScene.isElemental = isElemental;

            selectedNode.AddChild(new_EditScene);
        }
    }

}
