using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_InformationWindow : MonoBehaviour
{
    CombatController combatController;

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
        combatController = GetComponent<CombatController>();

        agility = combatController.Attributes.Agility.Amount;
        strength = combatController.Attributes.Strength.Amount;
        wisdom = combatController.Attributes.Wisdom.Amount;
        endurance = combatController.Attributes.Endurance.Amount;

        criticalStrikeChance = combatController.CombatStats.CriticalStrikeChance.Value;
        dodgeChance = combatController.CombatStats.DodgeChance.Value;
        attackSpeed = combatController.CombatStats.AttackSpeed.Value;
        movementSpeed = combatController.CombatStats.MovementSpeed.Value;
        physicalDamage = combatController.CombatStats.PhysicalDamage.Value;
        magicalDamage = combatController.CombatStats.MagicalDamage.Value;
        physicalDefense = combatController.CombatStats.PhysicalDefense.Value;
        magicDefense = combatController.CombatStats.MagicDefense.Value;
        maxHealth = combatController.CombatStats.MaxHealth.Value;
        //healthRegen = character.CharacterLeague.CombatStats.HealthRegen.Amount;
        //M_E_F_Base = character.CharacterLeague.CombatStats.M_E_F_Base.Amount;
        //M_E_F_Regen = character.CharacterLeague.CombatStats.M_E_F_Regen.Amount;
        //staminaBase = character.CharacterLeague.CombatStats.StaminaBase.Amount;
        //staminaRegen = character.CharacterLeague.CombatStats.HealthRegen.Amount;

    }
}