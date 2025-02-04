using Godot;

public partial class AddSkillMenu : TabBar
{

	//paths to the scenes to load them and show them.
	private string AddElementalSkillMenuPath = "./DemonEditor/scenes/skill/add_elemental_skill.tscn";
	private string AddDeBuffSkillMenuPath = "./DemonEditor/scenes/skill/add_de_buff_skill.tscn";
	private string AddAilmentSkillMenuPath = "./DemonEditor/scenes/skill/add_ailment_skill.tscn";

	//Node where the loaded scenes will be instantiated
	private Control SkillNode;

	//drowpdown where the targets will be populated
	private OptionButton TargetDropdown;
	public override void _Ready(){
		SkillNode = GetNode<Control>("%SkillMenu");

		TargetDropdown = GetNode<OptionButton>("%TargetDropdown");
		InitData.PopulateNormalDropdown<Target>(TargetDropdown, InitData.targets);
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
}
