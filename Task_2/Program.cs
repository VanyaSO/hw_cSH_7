namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        FootballTeam team = new FootballTeam(new Player[] { new Player("Ліонель Мессі", "Нападник"), new Player("Кріштіану Роналду", "Нападник"), new Player("Вірджил ван Дейк", "Захисник"), new Player("Неймар", "Півзахисник")});

        foreach (Player player in team)
        {
            Console.WriteLine(player);
        }
    }
}