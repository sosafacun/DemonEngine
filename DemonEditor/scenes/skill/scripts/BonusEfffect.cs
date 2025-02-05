using Godot;
using System;
namespace DemonEditor;

public partial class BonusEfffect : Control
{
	private OptionButton AilmentDropdown;
	private OptionButton StatDropdown;
	private CheckBox PersistsAfterBattleCheckBox;
	public override void _Ready()
	{
		AilmentDropdown = GetNode<OptionButton>("%AilmentDropdown");
		GlobalMethods.PopulateAffinityDropdown<Ailment>(AilmentDropdown, InitData.ailments);

		StatDropdown = GetNode<OptionButton>("%StatDropdown");
		GlobalMethods.PopulateNormalDropdown<Stat>(StatDropdown, InitData.stats);

		PersistsAfterBattleCheckBox = GetNode<CheckBox>("%PersistsAfterBattleCheckBox");
	}

	private void PersistsAfterBattleToggle(int index){
		PersistsAfterBattleCheckBox.ButtonPressed = InitData.ailments[index].LastsAfterBattle;
	}
}
