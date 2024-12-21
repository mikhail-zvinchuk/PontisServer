using Pontis.CardDatabases;
using Pontis.Interfaces;

namespace Pontis.Game;

// TODO rename calsses to remove the Pontis prefix, it is needed only for the time of code transaltion
public class Deck : ICardContainer
{
    private Queue<ICard> _cards = new();
    private IDeckDefinition _deckDefinition;

    public IEnumerable<ICard> Cards => _cards;

    public IDeckDefinition DeckDefinition
    {
        get => _deckDefinition;
        private set => _deckDefinition = value;
    }

    public Deck(IDeckDefinition? deckDefinition = null)
    {
        // TODO Pull up default deck
        this.DeckDefinition = deckDefinition ?? new NoJacks();
        Intialise();
    }

    public void AddCard(ICard card)
    {
        card.Open = false; // This is just to be extra safe 
        _cards.Enqueue(card);
    }
    
    public ICard? DrawCard()
    {
        return _cards.Count > 0 ? _cards.Dequeue() : null;
    }

    internal void ShuffleCards()
    {
        _cards = new Queue<ICard>(_cards.OrderBy(_ => Guid.NewGuid()));
    }

    internal void InitialiseInDefaultSequene()
    {
        _cards.Clear();
        foreach (var card in DeckDefinition.Cards)
        {
            _cards.Enqueue(card);
        }
    }

    public void Intialise()
    {
        InitialiseInDefaultSequene();
        ShuffleCards(); 
    }
   
}