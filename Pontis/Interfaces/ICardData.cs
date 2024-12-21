namespace Pontis.Interfaces;

public interface ICardData
{
    Constants.Kinds? Kind { get; }
    string Name { get; }
    Constants.Types Type { get; }
    int? Value { get; }
}