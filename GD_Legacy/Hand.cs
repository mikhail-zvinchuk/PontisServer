using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

public class Hand : IPlayerHand
{
    public delegate void CardReadyForPontisHandler(Card card);
    public event CardReadyForPontisHandler CardReadyForPontis;

    private bool activePlayer = false;
    private CardContainer cardContainer;
    private object cardReceiver;
    private object deck;

    public IEnumerable<ICard> GetCardsInHand() => cardContainer.Cards;

    public void AddToHand(Card card)
    {
        //card.transform.SetParent(deck);
        //card.gameObject.SetActive(true);

        //Vector3 targetPosition = cardReceiver.position;
        //card.transform.DOMove(targetPosition, 0.2f).OnComplete(() =>
        //{
        //    card.GetComponent<Card>().CardClicked += CardClickHandler;
        //    if (activePlayer)
        //    {
        //        card.ToggleDisabled();
        //        card.Reveal();
        //    }
        //    card.transform.SetParent(cardContainer);
        //});
    }

    public void PutToPontis(Card card)
    {
        card.ToggleDisabled();
        CardReadyForPontis?.Invoke(card);
    }

    public void LayCombo(List<Card> comboList)
    {
        // Implement combo laying logic here
    }

    internal void CardClickHandler(Card card)
    {
        //card.transform.SetParent(null);
        PutToPontis(card);
    }

}