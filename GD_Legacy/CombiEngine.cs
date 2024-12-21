using Pontis.Interfaces;

namespace Pontis.GD_Legacy;

public class CombiEngine : ICombiEngine
{
    public enum ComboDimension
    {
        Set,
        Sequence
    }

    public enum ComboType
    {
        Seed,
        Addon
    }

    public class Combo
    {
        public ComboType? Type { get; set; }
        public ComboDimension? Dimension { get; set; }
        public bool Valid { get; set; }
        public List<object> Composition { get; set; } = new List<object>();
    }

    public List<Combo> GetComboListFromCardCollections(
        object hand,
        object field,
        object oponentFields,
        object pontis)
    {
        // TODO: Implement the logic to generate the combo list
        return new List<Combo>();
    }

    public bool IsValidCombo(Combo combo)
    {
        // TODO: Implement the logic to validate the combo
        return false;
    }
}