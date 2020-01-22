
public interface ICharacterLeague
{
    IAbilityHandler AbilityHandler { get; }
    ICombatStatsHandler CombatStats { get; }

    string ToString();
}
