using Pontis.Interfaces;

namespace Pontis.Game;

/// <summary>
/// Player that playes Pontis
/// Responsibilities:
/// - Actions that player can undertake
/// </summary>
public class PontisPlayer : IPlayer
{
    //TODO
    public IPlayerHand Hand => throw new NotImplementedException();
    public MeldZone MeldZone { get; }

    public Constants.Types Type => throw new NotImplementedException();

    public IDealer Dealer => throw new NotImplementedException();

    public event Action FinishedGame;
    public event Action FinishedTurn;

    public void PlayTurn()
    {
        throw new NotImplementedException();
    }

    public void ReceiveCard(ICard card)
    {
        throw new NotImplementedException();
    }

    public void SetExternalID()
    {
        throw new NotImplementedException();
    }

    public void SetNPC()
    {
        throw new NotImplementedException();
    }

    public void GetState()
    {
        throw new NotImplementedException();
    }

    public void Draw(ICardContainer cards)
    {
        throw new NotImplementedException();
    }
}