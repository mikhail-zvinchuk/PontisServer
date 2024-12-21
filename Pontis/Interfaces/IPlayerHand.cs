
namespace Pontis.Interfaces;

public interface IPlayerHand
{

    void AddToHand(ICard card);
    IEnumerable<ICard> GetCardsInHand();
    void LayCombo(List<ICard> comboList);
    void PutToPontis(ICard card);
}