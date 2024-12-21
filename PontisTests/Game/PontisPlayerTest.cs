using Pontis.Game;
using Pontis.Interfaces;
using Assert = NUnit.Framework.Assert;

namespace PontisTests.Game;

[TestFixture]
[TestOf(typeof(PontisPlayer))]
public class PontisPlayerTest
{

    [Test]
    public void ExpectedUsage()
    {
        IPlayer player = new PontisPlayer();

        
        player.SetExternalID();
        player.SetNPC();
        player.GetState();
        ICardContainer cards = new Deck();
        player.Draw(cards);
        var hand = player.Hand;
        
        Assert.Fail();
    }
}