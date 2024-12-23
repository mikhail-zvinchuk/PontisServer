using Pontis.CardDatabases;
using Pontis.Constants;
using Pontis.Interfaces;
using Assert = NUnit.Framework.Assert;

namespace PontisTests.CardDatabases;

[TestFixture]
public class NoJacksTests
{
    private NoJacks _noJacks;

    [SetUp]
    public void Setup()
    {
        _noJacks = new NoJacks();
    }

    [Test]
    public void Cards_ShouldContain52Cards()
    {
        Assert.That(_noJacks.Cards.Count(), Is.EqualTo(52));
    }

    [Test]
    public void Cards_ShouldContainAllSuits()
    {
        var suits = _noJacks.Cards.Select(c => c.Suit).Distinct();
        var suitsEnumerable = suits as Suits[] ?? suits.ToArray();
        Assert.That(suitsEnumerable.Count(), Is.EqualTo(4));
        Assert.That(suitsEnumerable, Does.Contain(Pontis.Constants.Suits.Clubs));
        Assert.That(suitsEnumerable, Does.Contain(Pontis.Constants.Suits.Diamond));
        Assert.That(suitsEnumerable, Does.Contain(Pontis.Constants.Suits.Hearts));
        Assert.That(suitsEnumerable, Does.Contain(Pontis.Constants.Suits.Spades));
    }

    [Test]
    public void Cards_ShouldContainAllKinds()
    {
        var kinds = _noJacks.Cards.Select(c => c.Kind).Distinct();
        var kindsEnumerable = kinds as Kinds[] ?? kinds.ToArray();
        Assert.That(kindsEnumerable.Count(), Is.EqualTo(13));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Ace));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.King));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Queen));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Jack));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Ten));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Nine));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Eight));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Seven));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Six));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Five));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Four));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Three));
        Assert.That(kindsEnumerable, Does.Contain(Pontis.Constants.Kinds.Two));
    }

    [Test]
    public void Cards_ShouldHaveCorrectScores()
    {
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Ace), Has.All.Matches<ICard>(c => c.Score == 11));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.King), Has.All.Matches<ICard>(c => c.Score == 10));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Queen), Has.All.Matches<ICard>(c => c.Score == 10));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Jack), Has.All.Matches<ICard>(c => c.Score == 10));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Ten), Has.All.Matches<ICard>(c => c.Score == 10));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Nine), Has.All.Matches<ICard>(c => c.Score == 9));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Eight), Has.All.Matches<ICard>(c => c.Score == 8));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Seven), Has.All.Matches<ICard>(c => c.Score == 7));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Six), Has.All.Matches<ICard>(c => c.Score == 6));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Five), Has.All.Matches<ICard>(c => c.Score == 5));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Four), Has.All.Matches<ICard>(c => c.Score == 4));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Three), Has.All.Matches<ICard>(c => c.Score == 3));
        Assert.That(_noJacks.Cards.Where(c => c.Kind == Pontis.Constants.Kinds.Two), Has.All.Matches<ICard>(c => c.Score == 2));
    }

    [Test]
    public void Cards_ShouldNotContainJokers()
    {
        Assert.That(_noJacks.Cards, Has.All.Matches<ICard>(c => !c.IsJoker));
    }

    [Test]
    public void Cards_ShouldAllBeClosedInitially()
    {
        Assert.That(_noJacks.Cards, Has.All.Matches<ICard>(c => !c.Open));
    }

    [Test]
    public void Cards_ShouldAllBelongToDeck()
    {
        Assert.That(_noJacks.Cards, Has.All.Matches<ICard>(c => c.Owner == Pontis.Constants.Owners.Deck));
    }

    [Test]
    public void Cards_ShouldAllHaveNoMeld()
    {
        Assert.That(_noJacks.Cards, Has.All.Matches<ICard>(c => c.Meld == null));
    }
}