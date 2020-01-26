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
        Debug.Log(emptyArrayToPopulate.Length);
        return RogueCombatStatFactory.Create(combatController, emptyArrayToPopulate);
    }
}

public static class RogueCombatStatFactory
{
    public static ICombatStat[] Create(ICombatController combatController, ICombatStat[] combatStats)
    {
        combatStats[0] = new Rogue_CombatStat(CombatStatType.CriticalStrikeChance,
            combatController.Attributes.Agility,
            combatController.Attributes.Strength);

        combatStats[1] = new Rogue_CombatStat(CombatStatType.DodgeChance,
            combatController.Attributes.Agility,
            combatController.Attributes.Strength);

        combatStats[2] = new Rogue_CombatStat(CombatStatType.PhysicalDamage,
            combatController.Attributes.Strength,
            combatController.Attributes.Agility);

        combatStats[3] = new Rogue_CombatStat(CombatStatType.MagicalDamage,
            combatController.Attributes.Wisdom,
            combatController.Attributes.Agility);

        combatStats[4] = new Rogue_CombatStat(CombatStatType.MovementSpeed,
            combatController.Attributes.Agility,
            combatController.Attributes.Endurance); //TODO Make Nullable

        combatStats[5] = new Rogue_CombatStat(CombatStatType.AttackSpeed,
            combatController.Attributes.Agility,
            combatController.Attributes.Agility); //TODO Make Nullable

        combatStats[6] = new Rogue_CombatStat(CombatStatType.PhysicalDefense,
            combatController.Attributes.Endurance,
            combatController.Attributes.Agility); //TODO Make Nullable

        combatStats[7] = new Rogue_CombatStat(CombatStatType.MagicDefense,
            combatController.Attributes.Wisdom,
            combatController.Attributes.Agility); //TODO Make Nullable

        combatStats[8] = new Rogue_CombatStat(CombatStatType.MaxHealth,
            combatController.Attributes.Strength,
            combatController.Attributes.Endurance);

        combatStats[9] = new Rogue_CombatStat(CombatStatType.Health_RegenerationRate,
            combatController.Attributes.Strength,
            combatController.Attributes.Endurance);

        combatStats[10] = new Rogue_CombatStat(CombatStatType.M_E_F_Base,
            combatController.Attributes.Endurance,
            combatController.Attributes.Agility); //TODO Make Nullable

        combatStats[11] = new Rogue_CombatStat(CombatStatType.M_E_F_RegenerationRate,
            combatController.Attributes.Agility,
            combatController.Attributes.Endurance);

        combatStats[12] = new Rogue_CombatStat(CombatStatType.Stamina_Base,
            combatController.Attributes.Agility,
            combatController.Attributes.Endurance);

        combatStats[13] = new Rogue_CombatStat(CombatStatType.Stamina_RegenerationRate,
            combatController.Attributes.Agility,
            combatController.Attributes.Endurance);

        return combatStats;
    }
}