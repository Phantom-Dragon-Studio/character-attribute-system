namespace PhantomDragonStudio.HeroSystem
{
    public class Rogue : CharacterLeague
    {
        public override CharacterLeagueType LeagueType => CharacterLeagueType.Rogue;

        public override ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate)
        {
            return RogueCombatStatFactory.Create(combatController, emptyArrayToPopulate);
        }
    }

    /// <summary>
//  Initializes the type and value of all combat stats for the rogue. Assigning unique listerners
//  If you want to change WHAT attibutes each combat stat listens to, you may do that inside this function below.
//  Note: Here we have implemented the null implementation pattern. You subscribe to an empty attibute's events
//  only if you wish to not utilize the secondary attribute for that given stat.
    /// </summary>
    public static class RogueCombatStatFactory
    {
        public static ICombatStat[] Create(ICombatController combatController, ICombatStat[] combatStats)
        {
            combatStats[0] = new RogueStat(CombatStatType.CriticalStrikeChance,
                combatController.Attributes.Agility,
                combatController.Attributes.Strength);

            combatStats[1] = new RogueStat(CombatStatType.DodgeChance,
                combatController.Attributes.Agility,
                combatController.Attributes.Strength);

            combatStats[2] = new RogueStat(CombatStatType.PhysicalDamage,
                combatController.Attributes.Strength,
                combatController.Attributes.Agility);

            combatStats[3] = new RogueStat(CombatStatType.MagicalDamage,
                combatController.Attributes.Wisdom,
                combatController.Attributes.Agility);

            combatStats[4] = new RogueStat(CombatStatType.MovementSpeed,
                combatController.Attributes.Agility,
                combatController.Attributes.NULL);

            combatStats[5] = new RogueStat(CombatStatType.AttackSpeed,
                combatController.Attributes.Agility,
                combatController.Attributes.NULL);

            combatStats[6] = new RogueStat(CombatStatType.PhysicalDefense,
                combatController.Attributes.Endurance,
                combatController.Attributes.NULL); 

            combatStats[7] = new RogueStat(CombatStatType.MagicDefense,
                combatController.Attributes.Wisdom,
                combatController.Attributes.NULL);

            combatStats[8] = new RogueStat(CombatStatType.MaxHealth,
                combatController.Attributes.Strength,
                combatController.Attributes.Endurance);

            combatStats[9] = new RogueStat(CombatStatType.Health_RegenerationRate,
                combatController.Attributes.Strength,
                combatController.Attributes.Endurance);

            combatStats[10] = new RogueStat(CombatStatType.M_E_F_Base,
                combatController.Attributes.Endurance,
                combatController.Attributes.NULL);

            combatStats[11] = new RogueStat(CombatStatType.M_E_F_RegenerationRate,
                combatController.Attributes.Agility,
                combatController.Attributes.Endurance);

            combatStats[12] = new RogueStat(CombatStatType.Stamina_Base,
                combatController.Attributes.Agility,
                combatController.Attributes.Endurance);

            combatStats[13] = new RogueStat(CombatStatType.Stamina_RegenerationRate,
                combatController.Attributes.Agility,
                combatController.Attributes.Endurance);

            return combatStats;
        }
    }
}