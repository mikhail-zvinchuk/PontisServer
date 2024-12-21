using Pontis.Interfaces;

namespace Pontis.Game;

/// <summary>
/// Combines together everything that is needed for a Game of Pontis
/// Responsibilities:
/// - Dispatch and binding of game objects
/// - Turn order and progression
/// </summary>
public class PontisTable : IGameTable
{
    private const int numberOfSeats = 4;
    public int SeatsTaken { get { return seats.Count; } }

    public static int NumberOfSeats => numberOfSeats;

    private List<IPlayer> seats;

    public PontisDealer Dealer { get; private set; }

    public PontisTable() { 
        seats = new List<IPlayer>();
        Dealer = new PontisDealer();
    }

    public int TakeSeat(IPlayer player)
    {
        if (seats.Count < NumberOfSeats)
        {
            seats.Add(player);
            return seats.Count;
        }
        else
        {
            return -1;
        }
            
    }

    public void StartGame()
    {
        Dealer.DrawCard();
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

    public ICard DrawCard()
    {
        throw new NotImplementedException();
    }

    public void DrawCardFromDeck()
    {
        throw new NotImplementedException();
    }
}