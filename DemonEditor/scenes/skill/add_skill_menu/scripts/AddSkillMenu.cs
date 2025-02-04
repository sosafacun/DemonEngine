using Godot;
using System;
using System.Collections.Generic;

public partial class AddSkillMenu : TabBar
{
	private string addElementalSkillMenuPath = "./DemonEditor/scenes/skill/add_skill_menu/add_elemental_skill.tscn";
	private string addDeBuffSkillMenuPath = "./DemonEditor/scenes/skill/add_skill_menu/add_de_buff_skill.tscn";
	private string addAilmentSkillMenuPath = "./DemonEditor/scenes/skill/add_skill_menu/add_ailment_skill.tscn";
	private Control skillNode;
	private List<Control> addSkillMenus = new List<Control>();
	public override void _Ready(){
		skillNode = GetNode<Control>("%SkillMenu");
	}


	public override void _Process(double delta){
	}

	private Control PreloadScenes(string scenePath){
		var preloadedScene = GD.Load<PackedScene>(scenePath);
		Control loadedMenu = preloadedScene.Instantiate<Control>();
		return loadedMenu;
	}
	private void SkillTypeSelection(int index){
		switch(index){
			case 0: ShowSelectedMenu(addElementalSkillMenuPath);
				break;
			case 1: ShowSelectedMenu(addDeBuffSkillMenuPath);
				break;
			case 2: ShowSelectedMenu(addAilmentSkillMenuPath);
				break;
		}
	}

	private void ShowSelectedMenu(string menuPath){
		foreach (Control child in skillNode.GetChildren()){
			child.QueueFree();
		}
		var packedScene = GD.Load<PackedScene>(menuPath);
		Control newLoadedMenu = packedScene.Instantiate<Control>();

		skillNode.AddChild(newLoadedMenu);
	}
}
