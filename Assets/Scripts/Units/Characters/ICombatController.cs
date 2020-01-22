public interface ICombatController
{
    ICharacterAttributesHandler Attributes { get;}
    ICombatStatsHandler CombatStats { get;}
    IStatusEffectHandler StatusEffects { get;}
    IElementalResistanceHandler ElementalResistances { get; }
}