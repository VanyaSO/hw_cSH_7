namespace hw_cSH_7;

// Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму. Створіть клас для кожної істоти
// Океанаріуму. Вони мають містити інформацію про кожну
// морську істоту. Реалізуйте підтримку ітератора для класу
// «Океанаріум». Протестуйте можливість використання
// foreach для Океанаріуму

class Program
{
    static void Main(string[] args)
    {
        Oceanarium oceanarium = new Oceanarium(new AquaticAnimal[]{new Dolphin("Dolphin", 87, 16), new FurSeal("FurSeal", 150, 34), new FurSeal("FurSeal2", 100, 24)});

        foreach (AquaticAnimal animal in oceanarium)
        {
            Console.WriteLine(animal);
        }
    }
}