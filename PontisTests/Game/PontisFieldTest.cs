using FluentAssertions;
using Pontis.Game;


namespace PontisTests.Game;

[TestFixture]
[TestOf(typeof(PontisField))]
public class PontisFieldTest
{

[Test]
public void Cards_ShouldReturnEmptyByDefault()
{
    // Arrange
    var pontis = new PontisField();

    // Act
    var result = pontis.Cards;

    // Assert
    result.Should().BeEmpty();
}

[Test]
public void AddCard_ShouldAddCardToContainer()
{
    // Arrange
    var pontis = new PontisField();
    var card = new PontisCard(
        isJoker: false,
        kind: Pontis.Constants.Kinds.King,
        meld: null,
        open: false,
        owner: Pontis.Constants.Owners.Player,
        score: 10,
        suit: Pontis.Constants.Suits.Hearts);

    // Act
    pontis.AddCard(card);

    // Assert
    pontis.Cards.Should().Contain(card);
    card.Open.Should().BeTrue(); // Ensure the card's "Open" property is set to true as per the method's behavior.
}

[Test]
public void TakeCardsUntil_ShouldReturnExpectedCards()
{
    // Arrange
    var pontis = new PontisField();
    var targetCard = new PontisCard(
        isJoker: false,
        kind: Pontis.Constants.Kinds.King,
        meld: null,
        open: false,
        owner: Pontis.Constants.Owners.Player,
        score: 5,
        suit: Pontis.Constants.Suits.Clubs);

    var card1 = new PontisCard(
        isJoker: false,
        kind: Pontis.Constants.Kinds.King,
        meld: null,
        open: false,
        owner: Pontis.Constants.Owners.Player,
        score: 3,
        suit: Pontis.Constants.Suits.Spades);

    var card2 = new PontisCard(
        isJoker: true,
        kind: Pontis.Constants.Kinds.King,
        meld: null,
        open: false,
        owner: Pontis.Constants.Owners.Deck,
        score: 20,
        suit: Pontis.Constants.Suits.Hearts);

    pontis.AddCard(card1);
    pontis.AddCard(targetCard);
    pontis.AddCard(card2);

    // Act
    var result = pontis.TakeCardsUntil(targetCard);

    // Assert
    IEnumerable<PontisCard> pontisCards = result as PontisCard[] ?? result.ToArray();
    pontisCards.Should().ContainInOrder(card1, targetCard);
    pontisCards.Should().NotContain(card2);
}
}