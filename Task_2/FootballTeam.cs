using System.Collections;

namespace Task_2;

public class FootballTeam: IEnumerable
{
    private Player[] _team;

    public FootballTeam(Player[] team)
    {
        _team = new Player[team.Length];

        for (int i = 0; i < team.Length; i++)
        {
            _team[i] = team[i];
        }
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < _team.Length; i++)
        {
            yield return _team[i];
        }
    }
}