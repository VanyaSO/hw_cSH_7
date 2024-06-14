using System.Collections;

namespace hw_cSH_7;

public class Oceanarium: IEnumerable
{
    private AquaticAnimal[] _oceanariumArray;

    public Oceanarium(AquaticAnimal[] arrayList)
    {
        _oceanariumArray = new AquaticAnimal[arrayList.Length];
        for (int i = 0; i < arrayList.Length; i++)
        {
            _oceanariumArray[i] = arrayList[i];
        }
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < _oceanariumArray.Length; i++)
        {
            yield return _oceanariumArray[i];
        }
    }
}