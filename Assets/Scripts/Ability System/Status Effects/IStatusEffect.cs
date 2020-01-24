public interface IStatusEffect
{
    ElementalEffectType ElementalType { get; set; }
    AttributeType AttributeType { get; set; }
    PhysicalStatusEffectType PhysicalStatusEffect { get; }
}