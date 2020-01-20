using System;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class CombatStatsHandler : ICombatStatsHandler
{
    private Dictionary<CombatStatType, ICombatStat> combatStats = new Dictionary<CombatStatType, ICombatStat>();

    //Any Getters & Setters added here for attributes will need to be added into the ICharacterAttribute Interface & Class as well for accessibility.
    public Dictionary<CombatStatType, ICombatStat> CombatStats { get => combatStats; }

    public ICombatStat CriticalStrikeChance => CombatStats[CombatStatType.CriticalStrikeChance];
    public ICombatStat DodgeChance => CombatStats[CombatStatType.DodgeChance];
    public ICombatStat BaseDamage => CombatStats[CombatStatType.BaseDamage];
    public ICombatStat MovementSpeed => CombatStats[CombatStatType.MovementSpeed];
    public ICombatStat AttackSpeed => CombatStats[CombatStatType.AttackSpeed];
    public ICombatStat PhysicalDefense => CombatStats[CombatStatType.PhysicalDefense];
    public ICombatStat MagicDefense => CombatStats[CombatStatType.MagicDefense];
    //TODO Finish making the lower into their own classes.
    public ICombatStat HealthBase => CombatStats[CombatStatType.Health_Base];
    public ICombatStat HealthRegen => CombatStats[CombatStatType.Health_RegenerationRate];
    public ICombatStat M_E_F_Base => CombatStats[CombatStatType.M_E_F_Base];
    public ICombatStat M_E_F_Regen => CombatStats[CombatStatType.M_E_F_RegenerationRate];
    public ICombatStat StaminaBase => CombatStats[CombatStatType.Stamina_Base];
    public ICombatStat StaminaRegen => CombatStats[CombatStatType.Stamina_RegenerationRate];

    public void AddCombatStat(ICombatStat combatStat)
    {
        if (!CombatStats.ContainsKey(combatStat.CombatStatType))
        {
            CombatStats.Add(combatStat.CombatStatType, combatStat);
        }
    }

    //TODO Add events to listen to from attributes.
}
