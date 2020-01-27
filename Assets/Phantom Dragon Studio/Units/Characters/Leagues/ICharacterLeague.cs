public enum CharacterLeagueType
{
    _None = 0,
    Rogue,
    Warrior,
    Wizard,
}


public interface ICharacterLeague
{
    string ToString();
    ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate);
}
