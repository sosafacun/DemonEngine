using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Godot;
using System.Windows.Markup;

public partial class InitData: Node{
    private static List<Element> _elements;
    public static List<Element> elements{
        get => _elements;
        set => _elements = value;
    }
    private static List<Resistance> _resistances;
    public static List<Resistance> resistances{
        get => _resistances;
        set => _resistances = value;
    }
    private static List<Ailment> _ailments;
    public static List<Ailment> ailments{
        get => _ailments;
        set => _ailments = value;
    }
    private static List<Race> _races;
    public static List<Race> races{
        get => _races;
        set => _races = value;
    }
    private static List<Stat> _stats;
    public static List<Stat> stats{
        get => _stats;
        set => _stats = value;
    }

    private static List<Target> _targets;
    public static List<Target> targets{
        get => _targets;
        set => _targets = value;
    }
    public override void _Ready()
	{
        LoadJsons();
    }

    private void LoadJsons(){

        //Read, parse and load resistances from the .json file into a List
        string resistancesJson = File.ReadAllText("./DemonEditor/data/resistance/resistances.json");
        var resistancesData = JsonConvert.DeserializeObject<Dictionary<string, List<Resistance>>>(resistancesJson);
        resistances = resistancesData["resistances"];

        //Read, parse and load elements from the .json file into a List
        string elementsJson = File.ReadAllText("./DemonEditor/data/affinity/element/elements.json");
        var elementsData = JsonConvert.DeserializeObject<Dictionary<string, List<Element>>>(elementsJson);
        elements = elementsData["elements"];

        //Read, parse and load ailments from the .json file into a List
        string ailmentsJson = File.ReadAllText("./DemonEditor/data/affinity/ailment/ailments.json");
        var ailmentsData = JsonConvert.DeserializeObject<Dictionary<string, List<Ailment>>>(ailmentsJson);
        ailments = ailmentsData["ailments"];
        
        //Read, parse and load races from the .json file into a List
        string racesJson = File.ReadAllText("./DemonEditor/data/race/races.json");
        var racesData = JsonConvert.DeserializeObject<Dictionary<string, List<Race>>>(racesJson);
        races = racesData["races"];

        //Read, parse and load stats from the .json file into a List
        string statsJson = File.ReadAllText("./DemonEditor/data/stat/stats.json");
        var statsData = JsonConvert.DeserializeObject<Dictionary<string, List<Stat>>>(statsJson);
        stats = statsData["stats"];
        
        //Read, parse and load targets from the .json file into a List
        string targetsJson = File.ReadAllText("./DemonEditor/data/skill/targets/targets.json");
        var targetData = JsonConvert.DeserializeObject<Dictionary<string, List<Target>>>(targetsJson);
        targets = targetData["targets"];
    }

    //Got tired of re-writing this, so I thought of a way to put it in here. Might move it to another global class later.
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