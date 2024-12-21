using Pontis.Game;

namespace Pontis.Interfaces;

public interface IPlayer
{
    IDealer Dealer { get; }
    IPlayerHand Hand { get; }
    
    MeldZone MeldZone { get; }
    Constants.Types Type { get; }

    event Action FinishedGame;
    event Action FinishedTurn;

    void PlayTurn();
    void ReceiveCard(ICard card);
    void SetExternalID();
    void SetNPC();
    void GetState();
    void Draw(ICardContainer cards);
}