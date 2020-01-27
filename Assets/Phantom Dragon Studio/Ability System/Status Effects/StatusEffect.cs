using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StatusEffect : IStatusEffect
{
    public StatusEffect()
    {
    }

    public PhysicalStatusEffectType PhysicalStatusEffect { get; private set; }
    public ElementalEffectType ElementalType { get; private set; }
    public AttributeType AttributeModifier { get; private set; }
    public ICombatStat EffectedStat { get; private set; }
    public float TickMaxStackCount { get; private set; }
    public float TickDuration { get; private set; }
    public override string ToString()
    {
        return $"Type: " + ElementalType.ToString() + "Duration: " + TickDuration.ToString() + "Bonus: " + EffectedStat.ToString();
    }
    
}