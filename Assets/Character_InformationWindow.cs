﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_InformationWindow : MonoBehaviour
{
    ICharacter character;
    ICombatController cc;

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

    void Start()
    {
        character = GetComponent<ICharacter>();
        cc = character.CombatController;
    }

    void Update()
    {
        agility = cc.Attributes.Agility.AttributeInfo.Value;
        strength = cc.Attributes.Strength.AttributeInfo.Value;
        wisdom = cc.Attributes.Wisdom.AttributeInfo.Value;
        endurance = cc.Attributes.Endurance.AttributeInfo.Value;

        criticalStrikeChance = cc.CombatStats.CriticalStrikeChance.Value;
        dodgeChance = cc.CombatStats.DodgeChance.Value;
        attackSpeed = cc.CombatStats.AttackSpeed.Value;
        movementSpeed = cc.CombatStats.MovementSpeed.Value;
        physicalDamage = cc.CombatStats.PhysicalDamage.Value;
        magicalDamage = cc.CombatStats.MagicalDamage.Value;
        physicalDefense = cc.CombatStats.PhysicalDefense.Value;
        magicDefense = cc.CombatStats.MagicDefense.Value;
        maxHealth = cc.CombatStats.MaxHealth.Value;
        //healthRegen = character.CharacterLeague.CombatStats.HealthRegen.Amount;
        //M_E_F_Base = character.CharacterLeague.CombatStats.M_E_F_Base.Amount;
        //M_E_F_Regen = character.CharacterLeague.CombatStats.M_E_F_Regen.Amount;
        //staminaBase = character.CharacterLeague.CombatStats.StaminaBase.Amount;
        //staminaRegen = character.CharacterLeague.CombatStats.HealthRegen.Amount;

    }
}