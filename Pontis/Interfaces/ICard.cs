using Pontis.Game;

namespace Pontis.Interfaces;

public interface ICard
{
    bool IsJoker { get;  }
    Constants.Kinds Kind { get; }
    Meld? Meld { get;  }
    bool Open { get; set; }
    Constants.Owners Owner { get;}
    int Score { get;  }
    Constants.Suits Suit { get;  }
}