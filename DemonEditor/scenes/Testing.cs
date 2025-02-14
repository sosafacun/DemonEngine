using Godot;
using System;
using System.Collections.Generic;
namespace DemonEditor;

public partial class Testing : Control{
	// Called when the node enters the scene tree for the first time.
    private Control ElementalNode;
    private Control AilmentNode;
    private Control ElementEditorNode;
    private Control AilmentEditorNode;
	public override void _Ready()
	{
        ElementalNode = GetNode<Control>("%Elements");
        AilmentNode = GetNode<Control>("%Ailments");

        ElementEditorNode = GetNode<Control>("%ElementEditor");
        AilmentEditorNode = GetNode<Control>("%AilmentEditor");
        DisplayMenu(ElementalNode, "./DemonEditor/scenes/resistances/elemental_dropdown.tscn", InitData.elements);
        DisplayMenu(AilmentNode, "./DemonEditor/scenes/resistances/ailment_dropdown.tscn", InitData.ailments);
        PopulateEditMenus(ElementEditorNode, InitData.elements, true);
        PopulateEditMenus(AilmentEditorNode, InitData.ailments, false);
	}

    //nodeName = node where the dropdowns and labels will be stored
    //scenePath = scene where the dropdown and label scene are stored. This will create the current aviable ailments / elements (useful for when CRUD is implemented)
    //List<A> any list with the Affinity Interface implementation = Element and Ailment classes have it.
    private static void DisplayMenu<A>(Control selectedNode, String scenePath, List<A> affinities) where A : IAffinity{
        //Since there are only 2 columns (elements and ailments), this takes care of both
        var dropdownMenu = GD.Load<PackedScene>(scenePath);
        //initial position
        int yPos = 50;

        foreach(A affinity in affinities){
            if(!affinity.IsDefault){
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
    private static void PopulateEditMenus<A>(Control selectedNode, List<A> affinities, bool isElemental) where A: IAffinity{
        int yPos = 50;

        foreach(A affinity in affinities){
            if(isElemental){
                selectedNode.AddChild(CreateNewAffinityEditor(yPos, isElemental, affinity));
                yPos += 50;

            } else if (!affinity.IsDefault) {
                selectedNode.AddChild(CreateNewAffinityEditor(yPos, isElemental, affinity));
                yPos += 50;
            }
        }
    }
    private static AffinityEditor CreateNewAffinityEditor(int yPos, bool isElemental, IAffinity affinity){
        var editTemplate = GD.Load<PackedScene>("./DemonEditor/scenes/affinity_editor/affinity_editor.tscn");
        
        AffinityEditor new_EditScene = editTemplate.Instantiate<AffinityEditor>();
        new_EditScene.GetNode<Label>("%Label").Text = affinity.Name;

        new_EditScene.Position = new Vector2(0, yPos);

        new_EditScene.isElemental = isElemental;

        return new_EditScene;
    }
}
