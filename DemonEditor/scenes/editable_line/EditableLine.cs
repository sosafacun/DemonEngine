using Godot;
using System;

namespace DemonEditor;
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

	private LineEdit lineEdit;
	public override void _Ready()
	{
		Label label = GetNode<Label>("./EditableLineLabel");
		label.Text = LabelText;

		lineEdit = GetNode<LineEdit>("%EditableLineEdit");
		lineEdit.PlaceholderText = LineEditPlaceholder;
		lineEdit.MaxLength = CharacterLimit;
	}

	public double GetTextAsDouble(){
		return Double.Parse(lineEdit.Text);
	}	
	public int GetTextAsInt(){
		return int.Parse(lineEdit.Text);
	}
	public string GetTextAsString(){
		return lineEdit.Text;
	}
}
