using System.Collections.Generic;
using Godot;
namespace DemonEditor;

public partial class GlobalMethods: Node{
    public static void PopulateNormalDropdown<D>(OptionButton dropdown, List<D> items) where D: IData{
        foreach(var item in items){
			dropdown.AddItem(item.Name);
		}
    }
    public static void PopulateAffinityDropdown<A>(OptionButton dropdown, List<A> items) where A: IAffinity{
        foreach(var item in items){
			dropdown.AddItem(item.Name);
		}
    }
}
