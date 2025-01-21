using Godot;

public class InitData{
    private static List<Element> elements { get; set; }
    private static List<Resistance> resistances { get; set; }
    private static List<Ailment> ailments {get; set;}
    private static List<Race> races {get;set;}
    private static List<Stat> stats {get;set;}

    public InitData(){}

    private void LoadJsons(){

        //Read, parse and load resistances from the .json file into a List
        string resistancesJson = File.ReadAllText("./data/resistances.json");
        var resistancesData = JsonConvert.DeserializeObject<Dictionary<string, List<Resistance>>>(resistancesJson);
        resistances = resistancesData["resistances"];

        //Read, parse and load elements from the .json file into a List
        string elementsJson = File.ReadAllText("./data/elements.json");
        var elementsData = JsonConvert.DeserializeObject<Dictionary<string, List<Element>>>(elementsJson);
        elements = elementsData["elements"];

        //Read, parse and load ailments from the .json file into a List
        string ailmentsJson = File.ReadAllText("./data/ailments.json");
        var ailmentsData = JsonConvert.DeserializeObject<Dictionary<string, List<Ailment>>>(ailmentsJson);
        ailments = ailmentsData["ailments"];
        
        //Read, parse and load races from the .json file into a List
        string racesJson = File.ReadAllText("./data/races.json");
        var racesData = JsonConvert.DeserializeObject<Dictionary<string, List<Race>>>(racesJson);
        races = racesData["races"];

        //Read, parse and load stats from the .json file into a List
        string statsJson = File.ReadAllText("./data/stats.json");
        var statsData = JsonConvert.DeserializeObject<Dictionary<string, List<Stat>>>(statsJson);
        stats = statsData["stats"];
    }

    public void showResistances(){
        foreach(element in elements){
            GD.Print(element.Name);
        }
    }
}