using Pontis.Game;
using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

public abstract class Card : ICard
{
    public Constants.Owners Owner { get; set; } = Constants.Owners.Deck;
    public bool Open { get; set; } = false;
    public bool IsJoker { get; set; } = false;
    public Meld Meld { get; set; } = null;
    public object CardData { get; set; } = null;
    // How much this card scores
    public int Score { get; set; } = 0;
    // How does this card compare to others
    public Constants.Kinds Kind { get; set; } = 0;
    // What is the suit of this card
    public Constants.Suits Suit { get; set; } = 0;

    public Card(Constants.Owners owner, bool open, bool isJoker, object meld, object cardData, int score, Constants.Kinds kind, Constants.Suits suit)
    {
        Owner = owner;
        Open = open;
        IsJoker = isJoker;
        Meld = (Meld?)meld;
        CardData = cardData;
        Score = score;
        Kind = kind;
        Suit = suit;
    }

    internal void ToggleDisabled()
    {
        throw new NotImplementedException();
    }
}