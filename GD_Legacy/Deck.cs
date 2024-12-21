using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

public class Deck : IDeck
{
    public object CardBasePrefab;

    public Dictionary<CardData, int> DeckComposition = new Dictionary<CardData, int>();

    private List<Card> DeckCurrent = new List<Card>();
    private List<Card> DeckPrestine = new List<Card>();

    public GameTable dealer;

    public void Start()
    {
        InitializeDeckComposition();
        LoadCards();
    }

    public void InitializeDeckComposition()
    {
        // Initialize DeckComposition here
        // Example:
        // DeckComposition[CardDatabase.Clubs_1] = 1;
        // DeckComposition[CardDatabase.Clubs_2] = 1;
        // ... (continue for all cards)
    }

    public Card DrawCard()
    {
        if (DeckCurrent.Count == 0)
        {
            //gameObject.SetActive(false);
            return null;
        }

        Card card = DeckCurrent[0];
        DeckCurrent.RemoveAt(0);

        //card.transform.position = transform.position - new Vector3(250, 250, 0);
        //card.gameObject.SetActive(true);

        return card;
    }

    public void Shuffle()
    {
        // Implement shuffle logic here
    }

    public int CurrentSize()
    {
        return DeckCurrent.Count;
    }

    public void LoadCards()
    {
        foreach (var entry in DeckComposition)
        {
            CardData cardData = entry.Key;
            int count = entry.Value;

            for (int i = 0; i < count; i++)
            {
                //GameObject cardObject = Instantiate(CardBasePrefab, transform);
                //Card card = cardObject.GetComponent<Card>();
                //card.SetCardInfo(cardData);
                //DeckCurrent.Add(card);
                //cardObject.SetActive(false);
            }
        }
    }

    public void OnPressed()
    {
        if (DeckCurrent.Count > 0)
        {
            dealer.DrawCardFromDeck();
        }
    }
}