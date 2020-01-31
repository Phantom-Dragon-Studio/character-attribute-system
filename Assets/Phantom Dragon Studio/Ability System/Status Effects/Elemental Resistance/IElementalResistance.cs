using PhantomDragonStudio.Tools;

namespace PhantomDragonStudio.Ability_System
{
    public interface IElementalResistance
    {
        TypeValuePair<ElementalEffectType, float> ResistanceInfo { get; set; }

        string ToString();
    }
}
