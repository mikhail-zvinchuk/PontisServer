using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

// Class to hold the data for each card
public class CardData : ICardData
{
    public CardDatabase.Types Type { get; }
    public int? Value { get; }
    public CardDatabase.Kinds? Kind { get; }
    public string Name { get; }

    public CardData(CardDatabase.Types type, int? value, CardDatabase.Kinds? kind, string name)
    {
        Type = type;
        Value = value;
        Kind = kind;
        Name = name;
    }
}