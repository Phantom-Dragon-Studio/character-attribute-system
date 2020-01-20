using System.Collections.Generic;
using UnityEngine;

public enum PhysicalStatusEffectType
{
    None,
    Burning,
    Frozen,
    Slowed,
    StaticallyCharged,
    Bleeding,
    Poisoned,
    Corrupted,
    Summoned,
    Silenced,
    Blinded,
    Rooted,
    Stunned,

}

[System.Serializable]
public class StatusEffect : IStatusEffect
{
    [SerializeField] private IElementalEffect effectType = default;
    [SerializeField] private ICombatStat effectedStat = default;
    [SerializeField] private AttributeType tickAmountModifier = default;
    [SerializeField] private PhysicalStatusEffectType physicalStatusEffect = default;
    [SerializeField] private float tickMaxStackCount = default;
    [SerializeField] private float tickDuration = default;
    [SerializeField] private float tickAmount = default;

    public IElementalEffect ElementalType { get => effectType; set => effectType = value; }
    public ICombatStat EffectedStat { get => effectedStat; set => effectedStat = value; }
    public AttributeType AttributeType { get => tickAmountModifier; set => tickAmountModifier = value; }
    public PhysicalStatusEffectType PhysicalStatusEffect { get => physicalStatusEffect; set => physicalStatusEffect = value; }
    public float TickMaxStackCount => tickMaxStackCount;
    public float TickDuration => tickDuration;
    public float TickAmount => tickAmount;

    public override string ToString()
    {
        return "Type: " + ElementalType.ToString() + "Duration: " + TickDuration.ToString() + "Bonus: " + EffectedStat.ToString();
    }
}