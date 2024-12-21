using Pontis.Interfaces;

namespace Pontis.Game;

public class PontisCard(
    bool isJoker,
    Constants.Kinds kind,
    Meld? meld,
    bool open,
    Constants.Owners owner,
    int score,
    Constants.Suits suit)
    : ICard
{
    public bool IsJoker { get; } = isJoker;
    public Constants.Kinds Kind { get; } = kind;
    public Meld? Meld { get; } = meld;
    public bool Open { get; set; } = open;
    public Constants.Owners Owner { get; private set; } = owner;
    public int Score { get; } = score;
    public Constants.Suits Suit { get; } = suit;

    public void ChangeOwner(Constants.Owners owner)
    {
        Owner = owner;
    }


}