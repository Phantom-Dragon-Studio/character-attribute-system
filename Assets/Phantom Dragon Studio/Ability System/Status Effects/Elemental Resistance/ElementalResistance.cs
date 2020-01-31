using PhantomDragonStudio.Tools;

namespace PhantomDragonStudio.Ability_System
{
    [System.Serializable]
    public class ElementalResistance : IElementalResistance
    {
        public ElementalResistance(ElementalEffectType type, float value)
        {
            ResistanceInfo = new TypeValuePair<ElementalEffectType, float>(type, value);
        }

        public TypeValuePair<ElementalEffectType, float> ResistanceInfo { get; set; }

        public override string ToString()
        {
            return ResistanceInfo.type + " " + ResistanceInfo.value;
        }
    }
}
