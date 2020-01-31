using Phantom_Dragon_Studio.Hero_System;
using UnityEngine;

namespace Phantom_Dragon_Studio.Ability_System
{
    [System.Serializable]
    public class StatusEffect : IStatusEffect
    {
        public StatusEffect()
        {
        }

        [SerializeField] private PhysicalStatusEffectType effectType;
        public PhysicalStatusEffectType PhysicalStatusEffect { get; private set; }
        public ElementalEffectType ElementalType { get; private set; }
        public AttributeType AttributeModifier { get; private set; }
        public ICombatStat EffectedStat { get; private set; }
    
        public override string ToString()
        {
            return $"Type: " + ElementalType.ToString() + "Duration: " + /*TickDuration.ToString() +*/ "Bonus: " + EffectedStat.ToString();
        }
    
    }
}