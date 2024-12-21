

namespace Pontis.Interfaces;

public interface IDealer
{
    ICard DrawCard();
    void PutCardOnPontis(ICard card);
}