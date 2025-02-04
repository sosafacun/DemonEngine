using Godot;
using System;

public partial class EditableLine : Control
{
	[Export]
	public string LabelText;
	[Export]
	public string LineEditPlaceholder;
	[Export]
	public bool OnlyAllowsNumbers;
	[Export]
	public int CharacterLimit;
	public override void _Ready()
	{
		Label label = GetNode<Label>("./EditableLineLabel");
		label.Text = LabelText;

		LineEdit lineEdit = GetNode<LineEdit>("%EditableLineEdit");
		lineEdit.PlaceholderText = LineEditPlaceholder;
		lineEdit.MaxLength = CharacterLimit;
	}
}
