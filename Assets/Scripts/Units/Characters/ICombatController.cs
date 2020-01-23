public interface ICombatController
{
    ICharacter Character { get; }
    ICharacterAttributesHandler Attributes { get;}
    ICombatStatsHandler CombatStats { get;}
    IStatusEffectHandler StatusEffects { get;}
    IElementalResistanceHandler ElementalResistances { get; }
}