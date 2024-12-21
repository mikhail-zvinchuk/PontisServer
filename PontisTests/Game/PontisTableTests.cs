using Pontis;
using Pontis.Game;
using Pontis.Interfaces;
using Assert = NUnit.Framework.Assert;

namespace PontisTests.Game;

[TestFixture]
public class PontisTableTests
{
    [Test]
    public void PontisTableTest()
    {
        Assert.Fail();
    }

    [Test]
    public void TakeSeatTest()
    {
        Assert.Fail();
    }

    [Test]
    public void DrawCardTest()
    {
        Assert.Fail();
    }

    [Test]
    public void DrawCardFromDeckTest()
    {
        Assert.Fail();
    }

    [Test]
    public void ExpectedUsage()
    {
        IGameTable pontisTable = new PontisTable();
        
        pontisTable.TakeSeat(new PontisPlayer()); 
        pontisTable.TakeSeat(new PontisPlayer());
        pontisTable.TakeSeat(new PontisPlayer());
        pontisTable.TakeSeat(new PontisPlayer());

        pontisTable.StartGame();
        pontisTable.PauseGame();
        pontisTable.Status();
        GameState state = pontisTable.GetGameState();
        pontisTable.StopGame();
        
        IGameTable pontisTable_new = new PontisTable();
        pontisTable_new.StartGame(state);
        
        Assert.Fail();
    }
}
