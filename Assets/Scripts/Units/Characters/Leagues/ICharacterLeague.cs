
public interface ICharacterLeague
{
    IAbilityHandler AbilityHandler { get; }
    ICombatStatsHandler CombatStats { get; }
    IStatusEffectHandler StatusEffectHandler { get; }
    IElementalResistanceHandler ResistanceHandler { get; }

    string ToString();
}
