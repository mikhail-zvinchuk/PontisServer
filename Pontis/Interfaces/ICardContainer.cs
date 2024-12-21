namespace Pontis.Interfaces;

public interface ICardContainer
{
    IEnumerable<ICard> Cards { get; }
    
}