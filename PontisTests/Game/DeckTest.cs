using FluentAssertions;
using Moq;
using Pontis.Game;
using Pontis.Interfaces;

namespace PontisTests.Game;

[TestFixture]
[TestOf(typeof(Deck))]
public class DeckTest
{

    [Test]
    public void DrawCardShouldReturnCard()
    {
        // Arrange
        var mockDeckDefinition = new Mock<IDeckDefinition>();
        mockDeckDefinition.Setup(d => d.Cards).Returns(new List<ICard>
        {
            new Mock<ICard>().Object, 
            new Mock<ICard>().Object, 
            new Mock<ICard>().Object
        });

        var pontisDeck = new Deck(mockDeckDefinition.Object);

        // Act
        var drawnCard = pontisDeck.DrawCard();

        // Assert
        drawnCard.Should().NotBeNull();
        pontisDeck.Cards.Should().HaveCount(2);
    }
    
    [Test]
    public void IntialiseShouldResetCards()
    {
        // Arrange
        var mockDeckDefinition = new Mock<IDeckDefinition>();
        mockDeckDefinition.Setup(d => d.Cards).Returns(new List<ICard>
        {
            new Mock<ICard>().Object, 
            new Mock<ICard>().Object, 
            new Mock<ICard>().Object
        });

        var pontisDeck = new Deck(mockDeckDefinition.Object);
        var drawnCard = pontisDeck.DrawCard();
        drawnCard.Should().NotBeNull();
        pontisDeck.Cards.Should().HaveCount(2);
        
        // Act
        pontisDeck.Intialise();
        
        // Assert
        pontisDeck.Cards.Should().HaveCount(3);
    }
}