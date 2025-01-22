using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Godot;

public partial class InitData: Node{
    private static List<Element> elements;
    private static List<Resistance> resistances;
    private static List<Ailment> ailments;
    private static List<Race> races;
    private static List<Stat> stats;

    public override void _Ready()
	{
        LoadJsons();
    }

    public void LoadJsons(){

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
    }

    public static List<Resistance> GetResistances() => resistances;
    public static List<Ailment> GetAilments() => ailments;
    public static List<Element> GetElements() => elements;
    public static List<Race> GetRaces() => races;
    public static List<Stat> GetStats(/*Demon demon*/) => stats;
}