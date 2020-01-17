using System.Collections.Generic;
using UnityEngine;

//public enum Stats
//{
//    None,
//    Health,
//    Health_RegenRate,
//    M_E_F,
//    M_E_F_RegenRate,
//    Stamina,
//    Stamina_RegenRate,
//    MovementSpeed,
//    AttackSpeed,
//    Dodge,
//    CriticalChance,
//    HealingReceived,
//}

//TODO Make ElementalEffect & StatusEffects into it's own class.

//public enum ElementalStatusEffect
//{
//    None,
//    Burning,
//    Frozen,
//    Slowed,
//    StaticallyCharged,
//    Bleeding,
//    Poisoned,
//    Corrupted,
//    Summoned,
//    Silenced,
//    Blinded,
//    Rooted,
//    Stunned,

//}

[System.Serializable]
public class StatusEffect : IStatusEffect
{
    [SerializeField] private IElementalEffect effectType = default;
    [SerializeField] private ICombatStat effectedStat = default;
    [SerializeField] private AttributeType tickAmountModifier = default;
    [SerializeField] private float tickMaxStackCount = default;
    [SerializeField] private float tickDuration = default;
    [SerializeField] private float tickAmount = default;

    public IElementalEffect EffectType => effectType;
    public ICombatStat EffectedStat => effectedStat;
    public AttributeType TickAmountModifier => tickAmountModifier;
    public float TickMaxStackCount => tickMaxStackCount;
    public float TickDuration => tickDuration;
    public float TickAmount => tickAmount;

    public override string ToString()
    {
        return "Type: " + EffectType.ToString() + "Duration: " + TickDuration.ToString() + "Bonus: " + EffectedStat.ToString();
    }
}