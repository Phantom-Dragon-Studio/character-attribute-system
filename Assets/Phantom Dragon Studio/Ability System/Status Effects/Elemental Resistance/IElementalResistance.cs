public interface IElementalResistance
{
    TypeValuePair<ElementalEffectType, float> ResistanceInfo { get; set; }

    string ToString();
}
