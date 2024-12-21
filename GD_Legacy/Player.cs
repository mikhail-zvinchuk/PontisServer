using Pontis.Game;
using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

public class Player : IPlayer
{
    public Hand Hand { get; private set; }
    public MeldZone MeldZone { get; }
    public Dealer Dealer { get; private set; }
    public PlayerTypes Type { get; private set; }

    public enum PlayerTypes
    {
        HUMAN,
        NPC
    }

    public event Action FinishedTurn;
    public event Action FinishedGame;

    public Player(Dealer dealer, Hand participantHand, PlayerTypes playerType)
    {
        Hand = participantHand;
        Dealer = dealer;
        Type = playerType;
        Hand.CardReadyForPontis += PlayerReturnCard;
    }

    public void PlayTurn()
    {
        switch (Type)
        {
            case PlayerTypes.HUMAN:
                // TODO: start timer, await input
                // TODO: turn on the UI for the player
                break;
            case PlayerTypes.NPC:
                MakeNPCMove();
                break;
        }

        // TODO: add functionality
        // FinishedTurn?.Invoke();
    }

    public void ReceiveCard(Card card)
    {
        if (card != null)
        {
            Hand.AddToHand(card);
        }
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

    private void MakeNPCMove()
    {
        Card cardFromPontis = CheckPontisForCardThatCanBeLayed();

        if (cardFromPontis != null)
        {
            List<Card> cardsFromPontis = GetCardsFromPontis();
            LayCards(cardsFromPontis);
            NPCReturnCard(cardsFromPontis);
        }
        else
        {
            ReceiveCard(Dealer.DrawCard());
            LayCards(null);
            NPCReturnCard(null);
        }
    }

    private Card CheckPontisForCardThatCanBeLayed()
    {
        // TODO: add actual check
        return null;
    }

    private List<Card> GetCardsFromPontis()
    {
        // TODO: add retrieval
        return new List<Card>();
    }

    private void LayCards(List<Card> cardsFromPontis)
    {
        // TODO: add laying
    }

    private void PlayerReturnCard(Card card)
    {
        Dealer.PutCardOnPontis(card);
        FinishedTurn?.Invoke();
    }

    private void NPCReturnCard(List<Card> cardsFromPontis)
    {
        IEnumerable<ICard> cardsInHand = Hand.GetCardsInHand();

        if (cardsFromPontis != null)
        {
            //cardsInHand.AddRange(cardsFromPontis);
        }

        ICard? choosenCard = cardsInHand.FirstOrDefault();
        //choosenCard.ToggleDisabled();
        //Hand.CardClickHandler(choosenCard);

        // TODO: real implementation
    }

    internal void AddToHand(Card card)
    {
        throw new NotImplementedException();
    }
}