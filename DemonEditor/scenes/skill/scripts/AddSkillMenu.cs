using System.Collections.Generic;
using Godot;
namespace DemonEditor;

public partial class AddSkillMenu : TabBar
{

	//paths to the scenes to load them and show them.
	private readonly string AddElementalSkillMenuPath = "./DemonEditor/scenes/skill/add_skill_menu/elemental.tscn";
	private readonly string AddDeBuffSkillMenuPath = "./DemonEditor/scenes/skill/add_skill_menu/de_buff.tscn";
	private readonly string AddAilmentSkillMenuPath = "./DemonEditor/scenes/skill/add_skill_menu/ailment.tscn";

	//Node where the loaded scenes will be instantiated
	private Control SkillNode;
	private Control ParentNode;
	//drowpdown where the targets will be populated
	private OptionButton TargetDropdown;
	private static List<Control> children = new List<Control>();
	private static AddSkillMenu menu = new AddSkillMenu();
	public override void _Ready(){
		menu = this;
		SkillNode = GetNode<Control>("%SkillMenu");

		TargetDropdown = GetNode<OptionButton>("%TargetDropdown");
		GlobalMethods.PopulateNormalDropdown(TargetDropdown, InitData.targets);
	}

	//Depending on the selected type of skill, the menu for that skill creation will pop up.
	private void SkillTypeSelection(int index){
		switch(index){
			case 0: ShowSelectedMenu(AddElementalSkillMenuPath);
				break;
			case 1: ShowSelectedMenu(AddDeBuffSkillMenuPath);
				break;
			case 2: ShowSelectedMenu(AddAilmentSkillMenuPath);
				break;
		}
	}

	//Loads the selected skill type menu creation and **QUEUES FREE** every other loaded creator menu.
	//TODO: Add a confirmation window
	private void ShowSelectedMenu(string menuPath){
		foreach (Control child in SkillNode.GetChildren()){
			child.QueueFree();
		}
		var packedScene = GD.Load<PackedScene>(menuPath);
		Control newLoadedMenu = packedScene.Instantiate<Control>();

		SkillNode.AddChild(newLoadedMenu);
	}

	//Get all the nodes inside the parent. This is used to save the data inside them.
	private static List<Control> _GetNodes(){
		foreach(Control node in menu.GetChildren()){
			children.Add(node);
		}
		return children;
	}
    public static List<Control> GetNodes() => _GetNodes();

    private void OnSaveButtonPressed(){
		SaveData.ElementalSkill(menu);
	}
}
