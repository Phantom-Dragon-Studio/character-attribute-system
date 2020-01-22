﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Note: A Null reference exception can be thrown by the AddAttribute line if the character sheet sends an attribute with a null value

public static class CombatStatHandlerFactory
{
    private static ICombatStat[] combatStats = new ICombatStat[Enum.GetNames(typeof(CombatStatType)).Length - 1];

    public static ICombatStatsHandler Create(ICharacter character)
    {
        var combatStats = GenerateCombatStats(character);
        var newAttributeHandler = new CombatStatsHandler();
        if (combatStats != null)
        {
            for (int i = 0; i < combatStats.Length; i++)
            {
                if (combatStats[i] != null)
                {
                    Debug.Log("Adding " + combatStats[i].CombatStatType + " to "+ character + ".");
                    newAttributeHandler.AddCombatStat(combatStats[i]);
                }
            }
        }
        else Debug.LogError("Null list recieved by CharacterStatHandler Factory.");

        return newAttributeHandler;
    }

    private static ICombatStat[] GenerateCombatStats(ICharacter character)
    {
        Debug.Log("Initializing Combat Stats....");
        combatStats[0] = new CS_CriticalStrike(character);
        combatStats[1] = new CS_Dodge(character);
        combatStats[2] = new CS_AttackSpeed(character);
        combatStats[3] = new CS_MovementSpeed(character);
        combatStats[4] = new CS_PhysicalDamage(character);
        combatStats[5] = new CS_PhysicalDefense(character);
        combatStats[6] = new CS_MagicalDamage(character);
        combatStats[7] = new CS_MagicDefense(character);
        combatStats[8] = new CS_Health(character);
        //combatStats[8] = CombatStatFactory.Create(CombatStatType.Health_RegenerationRate, 0);
        //combatStats[9] = CombatStatFactory.Create(CombatStatType.M_E_F_Base, 0);
        //combatStats[10] = CombatStatFactory.Create(CombatStatType.M_E_F_RegenerationRate, 0);
        //combatStats[11] = CombatStatFactory.Create(CombatStatType.Stamina_Base, 0);
        //combatStats[12] = CombatStatFactory.Create(CombatStatType.Stamina_RegenerationRate, 0);

        return combatStats;
    }
}
