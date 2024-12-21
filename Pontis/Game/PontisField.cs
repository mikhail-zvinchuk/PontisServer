using Pontis.Interfaces;

namespace Pontis.Game;

/// <summary>
/// The actual pontis
/// </summary>
public class PontisField : ICardContainer
{
    private Queue<PontisCard> _cards = new();
    
    public PontisField()
    {
        Cards = _cards;
    }

    public IEnumerable<ICard> Cards { get; }

    public void AddCard(PontisCard card)
    {
        card.Open = true;// This is just to be extra safe
        _cards.Enqueue(card);
    }
    
    public IEnumerable<PontisCard> TakeCardsUntil(ICard card)   
    {
        if (_cards.Contains(card))
        {
            while (_cards.Peek() != card)
            {
                yield return _cards.Dequeue();
            }
            yield return _cards.Dequeue();
        }
    }
}