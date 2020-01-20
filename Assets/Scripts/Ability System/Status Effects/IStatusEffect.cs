public interface IStatusEffect
{
    IElementalEffect ElementalType { get; set; }
    AttributeType AttributeType { get; set; }
    PhysicalStatusEffectType PhysicalStatusEffect { get; }
}