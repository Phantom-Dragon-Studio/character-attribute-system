using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Combat Stat Modifiers Sheet", menuName = "Phantom Dragon Studio/Settings Modifiers Sheet", order = 0)]
public class CombatStat_Modifiers_Sheet : ScriptableObject
{
    [SerializeField] private float criticalStrikeChance_perAttributePoint;
    [SerializeField] private float dodgeChance_perAttributePoint;
    [SerializeField] private float physicalDamage_perAttributePoint;
    [SerializeField] private float magicalDamage_perAttributePoint;
    [SerializeField] private float attackSpeed_perAttributePoint;
    [SerializeField] private float movementSpeed_perAttributePoint;
    [SerializeField] private float physicalDefense_perAttributePoint;
    [SerializeField] private float magicalDefense_perAttributePoint;
    [SerializeField] private float maxHealth_perAttributePoint;
    [SerializeField] private float healthRegen_perAttributePoint;
    [SerializeField] private float M_E_F_perAttributePoint;
    [SerializeField] private float M_E_F_Regen_perAttributePoint;
    [SerializeField] private float maxStamina_perAttributePoint;
    [SerializeField] private float staminaRegen_perAttributePoint;


    public Dictionary<CombatStatType, float> Settings { get; private set; } = new Dictionary<CombatStatType, float>();

    void OnEnable()
    {
        Settings.Add(CombatStatType.CriticalStrikeChance, criticalStrikeChance_perAttributePoint);
        Settings.Add(CombatStatType.DodgeChance, dodgeChance_perAttributePoint);
        Settings.Add(CombatStatType.PhysicalDamage, physicalDamage_perAttributePoint);
        Settings.Add(CombatStatType.MagicalDamage, magicalDamage_perAttributePoint);
        Settings.Add(CombatStatType.AttackSpeed, attackSpeed_perAttributePoint);
        Settings.Add(CombatStatType.MovementSpeed, movementSpeed_perAttributePoint);
        Settings.Add(CombatStatType.PhysicalDefense, physicalDefense_perAttributePoint);
        Settings.Add(CombatStatType.MagicDefense, magicalDefense_perAttributePoint);
        Settings.Add(CombatStatType.MaxHealth, maxHealth_perAttributePoint);
        Settings.Add(CombatStatType.Health_RegenerationRate, healthRegen_perAttributePoint);
        Settings.Add(CombatStatType.M_E_F_Base, M_E_F_perAttributePoint);
        Settings.Add(CombatStatType.M_E_F_RegenerationRate, M_E_F_Regen_perAttributePoint);
        Settings.Add(CombatStatType.Stamina_Base, maxStamina_perAttributePoint);
        Settings.Add(CombatStatType.Stamina_RegenerationRate, staminaRegen_perAttributePoint);
    }
}
