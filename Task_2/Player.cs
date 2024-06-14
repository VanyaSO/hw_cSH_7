namespace Task_2;

public class Player
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Player(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public override string ToString() => $"{Name} - {Position}";
}