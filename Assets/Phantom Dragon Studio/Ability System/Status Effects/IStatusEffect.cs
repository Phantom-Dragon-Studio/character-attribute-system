using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.Ability_System
{
    public interface IStatusEffect
    {
        PhysicalStatusEffectType PhysicalStatusEffect { get; }
        ElementalEffectType ElementalType { get; }
        AttributeType AttributeModifier { get; }
    }
}