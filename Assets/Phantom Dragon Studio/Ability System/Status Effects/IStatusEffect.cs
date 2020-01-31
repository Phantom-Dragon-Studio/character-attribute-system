using Phantom_Dragon_Studio.Hero_System;

namespace Phantom_Dragon_Studio.Ability_System
{
    public interface IStatusEffect
    {
        PhysicalStatusEffectType PhysicalStatusEffect { get; }
        ElementalEffectType ElementalType { get; }
        AttributeType AttributeModifier { get; }
    }
}