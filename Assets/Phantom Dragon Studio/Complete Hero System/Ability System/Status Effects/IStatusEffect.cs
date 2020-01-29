public interface IStatusEffect
{
    PhysicalStatusEffectType PhysicalStatusEffect { get; }
    ElementalEffectType ElementalType { get; }
    AttributeType AttributeModifier { get; }
}