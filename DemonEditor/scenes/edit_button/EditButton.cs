using Godot;
using System;

public partial class EditButton : Button
{
	//Parent node
	private Control node;
	//Label with the name of the ailment / element
	private Label label;
	//dropdown with the resistance
	private OptionButton dropdown;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		node = GetParent<Control>();
		label = node.GetNode<Label>("%Label");
		dropdown = node.GetNode<OptionButton>("%ResistanceDropdown");
	}

	private void EditButtonPressed(){
		GD.Print(label.Text);
		GD.Print(dropdown.Text);
	}
}
