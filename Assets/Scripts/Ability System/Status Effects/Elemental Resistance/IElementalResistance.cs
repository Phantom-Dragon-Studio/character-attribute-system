public interface IElementalResistance
{
    ElementalEffectType ElementalType { get; set; }
    float Amount { get; set; }

    string ToString();
}
