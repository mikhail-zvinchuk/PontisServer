using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

public class CardDisplay : ICardDisplay
{
    public event Action<CardDisplay> CardClicked;

    public string CardName { get; private set; }
    public object[] CardInfo { get; set; }

    private string CardBackName = "Back_Blue_1";
    private string CardBackImage;
    private string CardFrontImage;
    private bool revealed = false;
    private bool highlighted = false;

    private object cardButton;

    private void Start()
    {
        CardName = (string)CardInfo[3];
        CardFrontImage = $"Assets/cards/{CardInfo[3]}.png";
        CardBackImage = $"Assets/cards/{CardBackName}.png";

        SetButtonTexture(CardBackImage);
        ToggleDisabled();
    }

    public void ToggleDisabled()
    {
        //cardButton.interactable = !cardButton.interactable;
    }

    public void Reveal()
    {
        if (!revealed)
        {
            revealed = true;
            SetButtonTexture(CardFrontImage);
        }
    }

    private void SetButtonTexture(string texturePath)
    {
        //Sprite sprite = Resources.Load<Sprite>(texturePath);
        //cardButton.image.sprite = sprite;
    }

    public void OnCardPressed()
    {
        CardClicked?.Invoke(this);
    }

    public void OnCardMouseEnter()
    {
        //transform.localScale = new Vector3(1.1f, 1.1f, 1f);
    }

    public void OnCardMouseExit()
    {
        //transform.localScale = Vector3.one;
    }

    public void ToggleHighlight()
    {
        highlighted = !highlighted;
        // Implement highlight logic here
    }
}