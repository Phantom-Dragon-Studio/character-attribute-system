using Phantom_Dragon_Studio.Hero_System;

namespace Phantom_Dragon_Studio.Hero_System
{
    public enum CharacterLeagueType
    {
        _None = 0,
        Rogue,
        Warrior,
        Wizard,
    }


    public interface ICharacterLeague
    {
        CharacterLeagueType LeagueType { get; }
        string ToString();
        ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate);
    }
}