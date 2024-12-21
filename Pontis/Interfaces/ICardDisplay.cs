

namespace Pontis.Interfaces;

public interface ICardDisplay
{
    object[] CardInfo { get; set; }
    string CardName { get; }

    event Action<ICardDisplay> CardClicked;

    void OnCardMouseEnter();
    void OnCardMouseExit();
    void OnCardPressed();
    void Reveal();
    void ToggleDisabled();
    void ToggleHighlight();
}