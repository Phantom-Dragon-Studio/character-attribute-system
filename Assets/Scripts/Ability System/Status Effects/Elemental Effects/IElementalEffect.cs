public enum ElementalEffectType
{
    _None = 0,
    Fire,
    Water,
    Earth,
    Wind,
    Lightning,
    Divine,
    Dark,
    Arcane
}

public interface IElementalEffect
{
    ElementalEffectType ElementalType { get; set; }
    PhysicalStatusEffectType PhysicalEffectType { get; }
    float Amount { get; }
}
