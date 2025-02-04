using Godot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DemonEditor;
public partial class EditButton : Button
{
	[Export]
	bool isEditButton;
	//Parent node
	private AffinityEditor node;
	//Label with the name of the ailment / element
	private Label label;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		node = GetParent<AffinityEditor>();
		label = node.GetNode<Label>("%Label");
	}

	private void EditButtonPressed(){
		//checks if it's not the "Edit Button" (so delete button) and if the parent node has the elemental attribute selected
		if(!isEditButton && node.isElemental){
			//makes an object of the selected element to delete
			Element elementToDelete = InitData.elements.Find(e => e.Name == label.Text);
			//removes that object from the list
			InitData.elements.Remove(elementToDelete);
			//saves that removal to the .json
			SaveToJson("./DemonEditor/data/affinity/element/elements.json",InitData.elements,"elements");
		} else if (!isEditButton){
			Ailment ailmentToDelete = InitData.ailments.Find(a => a.Name == label.Text);
			InitData.ailments.Remove(ailmentToDelete);
			SaveToJson("./DemonEditor/data/affinity/ailment/ailments.json",InitData.ailments,"ailments");
			}
		}
		
	private static void SaveToJson<A>(String save_path,List<A> affinties, string jsonName) where A: IAffinity{
		//set the Dictionary key
		var affinityData = new Dictionary<string, List<A>>{
			{jsonName, affinties}
		};

		//stringify the list to parse to .json
		string updatedAffinityData = JsonConvert.SerializeObject(affinityData, Formatting.Indented);
		//save that .json
		using (StreamWriter sw = new StreamWriter(save_path)){sw.Write(updatedAffinityData);}
	}
}
