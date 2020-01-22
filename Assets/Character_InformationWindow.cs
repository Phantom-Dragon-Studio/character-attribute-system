using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_InformationWindow : MonoBehaviour
{
    Character character;
    CharacterLeague league;
    [Header("Raw Character Data Table")]
    [ShowOnly] [SerializeField] float agility;
    [ShowOnly] [SerializeField] float strength;
    [ShowOnly] [SerializeField] float wisdom;
    [ShowOnly] [SerializeField] float endurance;

    [ShowOnly] [SerializeField] float criticalStrikeChance;
    [ShowOnly] [SerializeField] float dodgeChance;
    [ShowOnly] [SerializeField] float physicalDamage;
    [ShowOnly] [SerializeField] float magicalDamage;
    [ShowOnly] [SerializeField] float movementSpeed;
    [ShowOnly] [SerializeField] float attackSpeed;
    [ShowOnly] [SerializeField] float magicDefense;
    [ShowOnly] [SerializeField] float physicalDefense;

    [ShowOnly] [SerializeField] float maxHealth;
    [ShowOnly] [SerializeField] float healthRegen;
    [ShowOnly] [SerializeField] float M_E_F_Base;
    [ShowOnly] [SerializeField] float M_E_F_Regen;
    [ShowOnly] [SerializeField] float staminaBase;
    [ShowOnly] [SerializeField] float staminaRegen;

    void Update()
    {
        character = GetComponent<Character>();
        league = GetComponent<CharacterLeague>();

        agility = character.Attributes.Agility.Amount;
        strength = character.Attributes.Strength.Amount;
        wisdom = character.Attributes.Wisdom.Amount;
        endurance = character.Attributes.Endurance.Amount;

        criticalStrikeChance = league.CombatStats.CriticalStrikeChance.Value;
        dodgeChance = league.CombatStats.DodgeChance.Value;
        attackSpeed = league.CombatStats.AttackSpeed.Value;
        movementSpeed = league.CombatStats.MovementSpeed.Value;
        physicalDamage = league.CombatStats.PhysicalDamage.Value;
        magicalDamage = league.CombatStats.MagicalDamage.Value;
        physicalDefense = league.CombatStats.PhysicalDefense.Value;
        magicDefense = league.CombatStats.MagicDefense.Value;
        maxHealth = league.CombatStats.MaxHealth.Value;
        //healthRegen = character.CharacterLeague.CombatStats.HealthRegen.Amount;
        //M_E_F_Base = character.CharacterLeague.CombatStats.M_E_F_Base.Amount;
        //M_E_F_Regen = character.CharacterLeague.CombatStats.M_E_F_Regen.Amount;
        //staminaBase = character.CharacterLeague.CombatStats.StaminaBase.Amount;
        //staminaRegen = character.CharacterLeague.CombatStats.HealthRegen.Amount;

    }
}