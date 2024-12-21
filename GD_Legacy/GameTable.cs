using System.Numerics;
using Pontis.Game;
using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

public class GameTable : IGameTable
{
    // Constants
    private static readonly Vector2 CardSize = new Vector2(125, 175);
    private object CardBasePrefab; // Assign this in the Inspector
    private Hand PlayerHandPrefab; // Assign this in the Inspector
    private object ParticipantPrefab; // Assign this in the Inspector

    private List<Card> CardSelected = new List<Card>();

    private Deck Deck; // Reference to the Deck script
    private Player player1;
    private Player player2;
    private Player player3;
    private Player player4;

    private List<Player> players = new List<Player>();
    private int currentPlayerIndex = 0;

    public int SeatsTaken => throw new NotImplementedException();

    private void Start()
    {

        Deck.dealer = this;

        player1 = CreateParticipant(Player.PlayerTypes.HUMAN, PlayerHandPrefab);
        player2 = CreateParticipant(Player.PlayerTypes.NPC, PlayerHandPrefab);
        player3 = CreateParticipant(Player.PlayerTypes.NPC, PlayerHandPrefab);
        player4 = CreateParticipant(Player.PlayerTypes.NPC, PlayerHandPrefab);

        players.Add(player1);
        players.Add(player2);
        players.Add(player3);
        players.Add(player4);

        // Assuming menu buttons are wired to this method
        //Menu.StartNewGameButton.onClick.AddListener(OnStartGameButtonPressed);
    }

    private Player CreateParticipant(Player.PlayerTypes playerType, object handPrefab)
    {
        var participant = new Player(new Dealer(), PlayerHandPrefab, playerType);
        participant.FinishedTurn += NextTurn;
        participant.FinishedGame += GameFinished;
        return participant;
    }

    public void DrawCardFromDeck()
    {
        Card card = Deck.DrawCard();
        if (card != null)
        {
            player1.AddToHand(card); // Assuming hands are managed for player1
        }
    }

    public Card DrawCard()
    {
        return Deck.DrawCard();
    }

    private void OnStartGameButtonPressed()
    {
        // Show settings button if you have one
        //SettingsButton.SetActive(true);

        // Clean the board
        Deck.Shuffle();

        // Initial dealing
        //StartCoroutine(DealInitialCards());
    }

    //private IEnumerator DealInitialCards()
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        for (int j = 0; j < 4; j++)
    //        {
    //            Card drawnCard = Deck.DrawCard();
    //            // TODO: Add animation of card movement
    //            players[j].ReceiveCard(drawnCard);
    //            yield return new WaitForSeconds(0.1f);
    //        }
    //    }

    //    // Put card on the pontis
    //    Card cardOnPontis = Deck.DrawCard();
    //    PutCardOnPontis(cardOnPontis);

    //    // End of dealing
    //    players[currentPlayerIndex].PlayTurn();
    //}

    private void NextTurn()
    {
        if (currentPlayerIndex < players.Count - 1)
        {
            currentPlayerIndex++;
        }
        else
        {
            currentPlayerIndex = 0;
        }

        //StartCoroutine(WaitAndPlayNextTurn());
    }

    //private IEnumerator WaitAndPlayNextTurn()
    //{
    //    yield return new WaitForSeconds(0.2f);
    //    players[currentPlayerIndex].PlayTurn();
    //}

    private void GameFinished()
    {
        // TODO: calculate score
        // TODO: reset board
    }

    public int TakeSeat(IPlayer player)
    {
        throw new NotImplementedException();
    }

    public void StartGame()
    {
        throw new NotImplementedException();
    }

    public void PauseGame()
    {
        throw new NotImplementedException();
    }

    public void Status()
    {
        throw new NotImplementedException();
    }

    public GameState GetGameState()
    {
        throw new NotImplementedException();
    }

    public void StopGame()
    {
        throw new NotImplementedException();
    }

    public void StartGame(GameState state)
    {
        throw new NotImplementedException();
    }

    //private void PutCardOnPontis(Card card)
    //{
    //    Pontis.AddCard(card); // Assuming Pontis is accessible
    //}
}