using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_InformationWindow : MonoBehaviour
{
    ICharacter character;
    ICombatController combatController;

    [ShowOnly] [SerializeField] private CharacterLeagueType leagueType;

    [Header("Combat Manager Attribute Settings")]
    [ShowOnly] [SerializeField] float primaryAttributeEffectiveness;
    [ShowOnly] [SerializeField] float secondaryAttributeEffectiveness;

    [Header("Attributes")]
    [ShowOnly] [SerializeField] float agility;
    [ShowOnly] [SerializeField] float strength;
    [ShowOnly] [SerializeField] float wisdom;
    [ShowOnly] [SerializeField] float endurance;

    [Header("Combat Stats")]
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

    [Header("Resistances")] 
    [ShowOnly] [SerializeField] float elementalResistanceFire;
    [ShowOnly] [SerializeField] float elementalResistanceWater;
    [ShowOnly] [SerializeField] float elementalResistanceEarth;
    [ShowOnly] [SerializeField] float elementalResistanceWind;
    [ShowOnly] [SerializeField] float elementalResistanceLightning;
    [ShowOnly] [SerializeField] float elementalResistanceDivine;
    [ShowOnly] [SerializeField] float elementalResistanceDark;
    [ShowOnly] [SerializeField] float elementalResistanceArcane;

    void Start()
    {
        character = GetComponent<ICharacter>();
        combatController = character.CombatController;
        leagueType = character.CharacterSheet.League.LeagueType;
        primaryAttributeEffectiveness = CombatManager.Instance.LeagueSettings[character.CharacterSheet.League.LeagueType].primaryAttributeAffectModifier;
        secondaryAttributeEffectiveness = CombatManager.Instance.LeagueSettings[character.CharacterSheet.League.LeagueType].secondaryAttributeAffectModifier;
    }

    void Update()
    {
        //Attributes
        agility = combatController.Attributes.Agility.AttributeInfo.value;
        strength = combatController.Attributes.Strength.AttributeInfo.value;
        wisdom = combatController.Attributes.Wisdom.AttributeInfo.value;
        endurance = combatController.Attributes.Endurance.AttributeInfo.value;

        //Combat Stats
        criticalStrikeChance = combatController.CombatStats.CriticalStrikeChance.Value;
        dodgeChance = combatController.CombatStats.DodgeChance.Value;
        attackSpeed = combatController.CombatStats.AttackSpeed.Value;
        movementSpeed = combatController.CombatStats.MovementSpeed.Value;
        physicalDamage = combatController.CombatStats.PhysicalDamage.Value;
        magicalDamage = combatController.CombatStats.MagicalDamage.Value;
        physicalDefense = combatController.CombatStats.PhysicalDefense.Value;
        magicDefense = combatController.CombatStats.MagicDefense.Value;
        maxHealth = combatController.CombatStats.MaxHealth.Value;
        healthRegen = combatController.CombatStats.HealthRegen.Value;
        M_E_F_Base = combatController.CombatStats.M_E_F_Base.Value;
        M_E_F_Regen = combatController.CombatStats.M_E_F_Regen.Value;
        staminaBase = combatController.CombatStats.StaminaBase.Value;
        staminaRegen = combatController.CombatStats.StaminaRegen.Value;

        //Elemental Resistances
        elementalResistanceFire = combatController.ElementalResistances.GetResistanceByType(ElementalEffectType.Fire).ResistanceInfo.value;
        elementalResistanceWater = combatController.ElementalResistances.GetResistanceByType(ElementalEffectType.Water).ResistanceInfo.value;
        elementalResistanceEarth = combatController.ElementalResistances.GetResistanceByType(ElementalEffectType.Earth).ResistanceInfo.value;
        elementalResistanceWind = combatController.ElementalResistances.GetResistanceByType(ElementalEffectType.Wind).ResistanceInfo.value;
        elementalResistanceLightning = combatController.ElementalResistances.GetResistanceByType(ElementalEffectType.Lightning).ResistanceInfo.value;
        elementalResistanceDivine = combatController.ElementalResistances.GetResistanceByType(ElementalEffectType.Divine).ResistanceInfo.value;
        elementalResistanceDark = combatController.ElementalResistances.GetResistanceByType(ElementalEffectType.Dark).ResistanceInfo.value;
        elementalResistanceArcane = combatController.ElementalResistances.GetResistanceByType(ElementalEffectType.Arcane).ResistanceInfo.value;
    }
}