using System.Collections.Generic;
using UnityEngine;

public enum PhysicalStatusEffectType
{
    _None = 0,
    Burning,
    Frozen,
    Slowed,
    StaticallyCharged,
    Bleeding,
    Poisoned,
    Corrupted,
    TimedLife,
    Silenced,
    Blinded,
    Rooted,
    Stunned,

}

[System.Serializable]
public class StatusEffect : IStatusEffect
{
    [field: SerializeField] public ElementalEffectType ElementalType { get; set; }
    [field: SerializeField] public ICombatStat EffectedStat { get; set; }
    [field: SerializeField] public AttributeType AttributeType { get; set; }
    [field: SerializeField] public PhysicalStatusEffectType PhysicalStatusEffect { get; set; }
    [field: SerializeField] public float TickMaxStackCount { get; set; }
    [field: SerializeField] public float TickDuration { get; set; }
    [field: SerializeField] public float TickAmount { get; set; }

    public override string ToString()
    {
        return "Type: " + ElementalType.ToString() + "Duration: " + TickDuration.ToString() + "Bonus: " + EffectedStat.ToString();
    }
}