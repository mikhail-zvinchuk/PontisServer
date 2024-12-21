namespace Pontis.Interfaces;

public interface IDeckDefinition
{
    IEnumerable<ICard> Cards { get; }
}