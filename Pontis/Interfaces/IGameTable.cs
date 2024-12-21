using Pontis.Game;


namespace Pontis.Interfaces;

public interface IGameTable
{
    int SeatsTaken { get; }

    ICard DrawCard();
    void DrawCardFromDeck();
    int TakeSeat(IPlayer player);
    void StartGame();
    void PauseGame();
    void Status();
    GameState GetGameState();
    void StopGame();
    void StartGame(GameState state);
}