using System.Collections.Generic;
using UnityEngine;

public enum Stats
{
    None,
    Health,
    Health_RegenRate,
    M_E_F,
    M_E_F_RegenRate,
    Stamina,
    Stamina_RegenRate,
    MovementSpeed,
    AttackSpeed,
    Dodge,
    CriticalChance,
    HealingReceived,
}

public enum StatusEffects
{
    None,
    Burning,
    Frozen,
    Slowed,
    Statically_Charged,
    Stunned,
    Bleeding,
    Poisoned,
    Rooted,

}
[System.Serializable]
public class StatusEffect : IStatusEffect
{
    [SerializeField] private StatusEffects effectType = default;
    [SerializeField] private Stats effectedStat = default;
    [SerializeField] private AttributeType tickAmountModifier = default;
    [SerializeField] private float tickMaxStackCount = default;
    [SerializeField] private float tickDuration = default;
    [SerializeField] private float tickAmount = default;

    public StatusEffects EffectType => effectType;
    public Stats EffectedStat => effectedStat;
    public AttributeType TickAmountModifier => tickAmountModifier;
    public float TickMaxStackCount => tickMaxStackCount;
    public float TickDuration => tickDuration;
    public float TickAmount => tickAmount;

    public override string ToString()
    {
        return "Type: " + EffectType.ToString() + "Duration: " + TickDuration.ToString() + "Bonus: " + EffectedStat.ToString();
    }
}