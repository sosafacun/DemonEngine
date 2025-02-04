public class Race: IData
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public Race(int id, string name)
    {
        Id = id;
        Name = name;
    }
}