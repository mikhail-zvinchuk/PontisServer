namespace Pontis.Game;

/// <summary>
/// Players Meld Zone where their layed Melds are laying
/// </summary>
public class MeldZone
{
    public List<Meld> Melds { get; }
    
    public int Score { get; private set; }

    public MeldZone()
    {
        Melds = new List<Meld>();
    }

    public void Add(Meld meld)
    {
        Score += meld.Score;
        Melds.Add(meld);
    }
}