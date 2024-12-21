

namespace Pontis.Interfaces;

public interface IGameBoard
{
    Dictionary<int, List<object>> Clubs { get; }
    Dictionary<int, List<object>> Diamonds { get; }
    Dictionary<int, List<object>> Hearts { get; }
    Dictionary<string, Dictionary<int, List<object>>> Matrix { get; }
    Dictionary<int, List<object>> Spades { get; }

    bool CheckIfCardSetIsValidMeld(List<ICard> cards);
}