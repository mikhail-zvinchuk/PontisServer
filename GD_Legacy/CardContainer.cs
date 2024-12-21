
using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

internal class CardContainer : ICardContainer
{
    public IEnumerable<ICard> Cards { get; internal set; }
}