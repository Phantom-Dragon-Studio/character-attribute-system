using System;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    /// <summary>
    /// A Null reference exception can be thrown by the AddAttribute line if the character sheet sends an attribute with a null value
    /// </summary>
    public static class CombatStatHandlerFactory
    {
        private static ICombatStat[] _combatStats = new ICombatStat[Enum.GetNames(typeof(CombatStatType)).Length - 1];

        public static ICombatStatsHandler Create(ICombatController combatController, ICharacterLeague leagueType)
        {
            GenerateCombatStats(combatController, leagueType);
            if (_combatStats != null)
                return new CombatStatsHandler(_combatStats);
            Debug.LogError("Null list received by CharacterStatHandler Factory.");
            return null;
        }

        private static void GenerateCombatStats(ICombatController combatController, ICharacterLeague leagueType)
        {
            _combatStats = leagueType.GenerateCombatStats(combatController, _combatStats);
        }
    }
}
