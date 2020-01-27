using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : CharacterLeague
{
    public override string ToString()
    {
        return "Rogue";
    }

    public override ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate)
    {
        return RogueCombatStatFactory.Create(combatController, emptyArrayToPopulate);
    }
}

public static class RogueCombatStatFactory
{

    //Initializes the type and value of all combat stats for the rogue. Assigning unique listerners
    //If you want to change WHAT attibutes each combat stat listens to, you may do that inside this function below.
    //Note: Here we have implemented the null implementation pattern. You subscribe to an empty attibute's events
    //only if you wish to not utilize the secondary attribute for that given stat.
    public static ICombatStat[] Create(ICombatController combatController, ICombatStat[] combatStats)
    {
        combatStats[0] = new CombatStat(CombatStatType.CriticalStrikeChance,
            combatController.Attributes.Agility,
            combatController.Attributes.Strength);

        combatStats[1] = new CombatStat(CombatStatType.DodgeChance,
            combatController.Attributes.Agility,
            combatController.Attributes.Strength);

        combatStats[2] = new CombatStat(CombatStatType.PhysicalDamage,
            combatController.Attributes.Strength,
            combatController.Attributes.Agility);

        combatStats[3] = new CombatStat(CombatStatType.MagicalDamage,
            combatController.Attributes.Wisdom,
            combatController.Attributes.Agility);

        combatStats[4] = new CombatStat(CombatStatType.MovementSpeed,
            combatController.Attributes.Agility,
            combatController.Attributes.NULL);

        combatStats[5] = new CombatStat(CombatStatType.AttackSpeed,
            combatController.Attributes.Agility,
            combatController.Attributes.NULL);

        combatStats[6] = new CombatStat(CombatStatType.PhysicalDefense,
            combatController.Attributes.Endurance,
            combatController.Attributes.NULL); 

        combatStats[7] = new CombatStat(CombatStatType.MagicDefense,
            combatController.Attributes.Wisdom,
            combatController.Attributes.NULL);

        combatStats[8] = new CombatStat(CombatStatType.MaxHealth,
            combatController.Attributes.Strength,
            combatController.Attributes.Endurance);

        combatStats[9] = new CombatStat(CombatStatType.Health_RegenerationRate,
            combatController.Attributes.Strength,
            combatController.Attributes.Endurance);

        combatStats[10] = new CombatStat(CombatStatType.M_E_F_Base,
            combatController.Attributes.Endurance,
            combatController.Attributes.NULL);

        combatStats[11] = new CombatStat(CombatStatType.M_E_F_RegenerationRate,
            combatController.Attributes.Agility,
            combatController.Attributes.Endurance);

        combatStats[12] = new CombatStat(CombatStatType.Stamina_Base,
            combatController.Attributes.Agility,
            combatController.Attributes.Endurance);

        combatStats[13] = new CombatStat(CombatStatType.Stamina_RegenerationRate,
            combatController.Attributes.Agility,
            combatController.Attributes.Endurance);

        return combatStats;
    }
}