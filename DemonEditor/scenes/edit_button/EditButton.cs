using Godot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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
		if(!isEditButton){
			if(node.isElemental){
				Element elementToDelete = InitData.elements.Find(e => e.Name == label.Text);
				InitData.elements.Remove(elementToDelete);
				SaveToJson("./DemonEditor/data/affinity/element/elements.json",InitData.elements,"elements");
			} else {
				Ailment ailmentToDelete = InitData.ailments.Find(a => a.Name == label.Text);
				InitData.ailments.Remove(ailmentToDelete);
				SaveToJson("./DemonEditor/data/affinity/ailment/ailments.json",InitData.ailments,"ailments");
			}
		}
	}
	private void SaveToJson<A>(String save_path,List<A> affinties, string jsonName) where A: IAffinity{

		var affinityData = new Dictionary<string, List<A>>{
			{jsonName, affinties}
		};

		string updatedAffinityData = JsonConvert.SerializeObject(affinityData, Formatting.Indented);
		using (StreamWriter sw = new StreamWriter(save_path)){sw.Write(updatedAffinityData);}
	}
}
