using Phantom_Dragon_Studio.Tools;

namespace Phantom_Dragon_Studio.Ability_System
{
    public interface IElementalResistance
    {
        TypeValuePair<ElementalEffectType, float> ResistanceInfo { get; set; }

        string ToString();
    }
}
