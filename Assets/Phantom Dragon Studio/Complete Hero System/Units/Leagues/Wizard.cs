namespace Phantom_Dragon_Studio.Hero_System
{
    public class Wizard : CharacterLeague
    {
        public override CharacterLeagueType LeagueType => CharacterLeagueType.Wizard;

        public override ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate)
        {
            return WizardCombatStatFactory.Create(combatController, emptyArrayToPopulate);
        }
    }

    /// <summary>
//  Initializes the type and value of all combat stats for the rogue. Assigning unique listerners
//  If you want to change WHAT attibutes each combat stat listens to, you may do that inside this function below.
//  Note: Here we have implemented the null implementation pattern. You subscribe to an empty attibute's events
//  only if you wish to not utilize the secondary attribute for that given stat.
    /// </summary>
    public static class WizardCombatStatFactory
    {
        public static ICombatStat[] Create(ICombatController combatController, ICombatStat[] combatStats)
        {

            combatStats[0] = new WizardStat(CombatStatType.CriticalStrikeChance,
                combatController.Attributes.Wisdom,
                combatController.Attributes.Agility);

            combatStats[1] = new WizardStat(CombatStatType.DodgeChance,
                combatController.Attributes.Wisdom,
                combatController.Attributes.Agility);

            combatStats[2] = new WizardStat(CombatStatType.PhysicalDamage,
                combatController.Attributes.Strength,
                combatController.Attributes.Agility);

            combatStats[3] = new WizardStat(CombatStatType.MagicalDamage,
                combatController.Attributes.Wisdom,
                combatController.Attributes.Agility);

            combatStats[4] = new WizardStat(CombatStatType.MovementSpeed,
                combatController.Attributes.Agility,
                combatController.Attributes.NULL);

            combatStats[5] = new WizardStat(CombatStatType.AttackSpeed,
                combatController.Attributes.Agility,
                combatController.Attributes.NULL);

            combatStats[6] = new WizardStat(CombatStatType.PhysicalDefense,
                combatController.Attributes.Endurance,
                combatController.Attributes.Strength);

            combatStats[7] = new WizardStat(CombatStatType.MagicDefense,
                combatController.Attributes.Wisdom,
                combatController.Attributes.NULL);

            combatStats[8] = new WizardStat(CombatStatType.MaxHealth,
                combatController.Attributes.Wisdom,
                combatController.Attributes.Endurance);

            combatStats[9] = new WizardStat(CombatStatType.Health_RegenerationRate,
                combatController.Attributes.Wisdom,
                combatController.Attributes.Endurance);

            combatStats[10] = new WizardStat(CombatStatType.M_E_F_Base,
                combatController.Attributes.Wisdom,
                combatController.Attributes.Endurance);

            combatStats[11] = new WizardStat(CombatStatType.M_E_F_RegenerationRate,
                combatController.Attributes.Wisdom,
                combatController.Attributes.Endurance);

            combatStats[12] = new WizardStat(CombatStatType.Stamina_Base,
                combatController.Attributes.Agility,
                combatController.Attributes.Endurance);

            combatStats[13] = new WizardStat(CombatStatType.Stamina_RegenerationRate,
                combatController.Attributes.Agility,
                combatController.Attributes.Endurance);

            return combatStats;
        }
    }
}