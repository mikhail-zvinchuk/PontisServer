

namespace Pontis.Interfaces;

public interface IDeck
{
    int CurrentSize();
    ICard DrawCard();
    void InitializeDeckComposition();
    void LoadCards();
    void OnPressed();
    void Shuffle();
    void Start();
}