namespace hw_cSH_7;

public class AquaticAnimal
{
    public string Name { get; set; }
    public uint Weight { get; set; }
    public uint SpeedKilometrsPerHour { get; set; }
    
    public AquaticAnimal() {}

    public AquaticAnimal(string name, uint weight, uint speed)
    {
        Name = name;
        Weight = weight;
        SpeedKilometrsPerHour = speed;
    }

    public override string ToString() => $"{Name}, {Weight} kg, {SpeedKilometrsPerHour} km/h";
}