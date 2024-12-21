using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

public class GameBoard : IGameBoard
{
    // Cell values: Owner, On table, Is joker, Meld
    public Dictionary<int, List<object>> Diamonds { get; } = Enumerable.Range(1, 13).ToDictionary(i => i, _ => new List<object>());
    public Dictionary<int, List<object>> Hearts { get; } = Enumerable.Range(1, 13).ToDictionary(i => i, _ => new List<object>());
    public Dictionary<int, List<object>> Clubs { get; } = Enumerable.Range(1, 13).ToDictionary(i => i, _ => new List<object>());
    public Dictionary<int, List<object>> Spades { get; } = Enumerable.Range(1, 13).ToDictionary(i => i, _ => new List<object>());

    public Dictionary<string, Dictionary<int, List<object>>> Matrix { get; } = new Dictionary<string, Dictionary<int, List<object>>>();

    public GameBoard()
    {
        Matrix["♦"] = Diamonds;
        Matrix["♥"] = Hearts;
        Matrix["♣"] = Clubs;
        Matrix["♠"] = Spades;
    }

    public enum Owners
    {
        Deck,
        Pontis,
        Player,
        Player2,
        Player3,
        Player4
    }

    public enum MeldType
    {
        Suit,
        Kind
    }

    public bool CheckIfCardSetIsValidMeld(List<Card> cards)
    {
        var meld = new Meld();
        return meld.IsMeld(cards);
    }

    public class Meld
    {
        public MeldType Type { get; set; } = MeldType.Kind;
        public List<object> Ends { get; } = new List<object>();
        public List<Card> Cards { get; } = new List<Card>();
        public object Owner { get; set; }
        public List<Meld> ExtensionMelds { get; } = new List<Meld>();

        public bool IsMeld(List<Card> cards)
        {
            if (cards.Count >= 3)
            {
                // checking for same kind
                int cardsOfSameKind = cards.Count(card => card.Kind == cards[0].Kind);
                if (cardsOfSameKind == cards.Count)
                {
                    // this is meld of same kind
                    Type = MeldType.Kind;
                    return true;
                }

                int cardsOfSameSuit = cards.Count(card => card.Suit == cards[0].Suit);
                if (cardsOfSameSuit == cards.Count)
                {
                    // this might be sequence of the same suit
                    cards.Sort(CardComparator);
                    Card prev = null;
                    foreach (var card in cards)
                    {
                        if (prev != null)
                        {
                            if (prev.Kind + 1 != card.Kind)
                            {
                                return false;
                            }
                        }
                        prev = card;
                    }
                    Type = MeldType.Suit;
                    return true;
                }
            }
            return false;
        }

        private int CardComparator(Card a, Card b)
        {
            return a.Kind.CompareTo(b.Kind);
        }

        public void FindMelds(List<Card> cards)
        {
            // TODO: Implement this method
        }

        public int Value()
        {
            return Cards.Sum(card => card.Score);
        }
    }

    public class MeldRegistry
    {
        public Dictionary<string, List<object>> Matrix { get; } = new Dictionary<string, List<object>>
        {
            ["♦"] = new List<object>(),
            ["♥"] = new List<object>(),
            ["♣"] = new List<object>(),
            ["♠"] = new List<object>()
        };

        public void BindMelds(object suitExisting, object randExisting, object extension)
        {
            // TODO: Implement this method
        }

        public void CheckIfExtension(Meld meld)
        {
            if (meld.Type == MeldType.Suit)
            {
                foreach (var end in meld.Ends)
                {
                    int index = Matrix[meld.Cards[0].Suit.ToString()].IndexOf(end);
                    if (index != -1)
                    {
                        BindMelds(meld.Cards[0].Suit.ToString(), Matrix[meld.Cards[0].Suit.ToString()][index], meld);
                    }
                }
            }
        }
    }
}