﻿using UnityEngine;

namespace Phantom_Dragon_Studio.Ability_System
{
    public enum TargetingType
    {
        None,
        Self,
        SingleTarget_Melee,
        SingleTarget_Ranged,
        AreaOfEffect_Local,
        AreaOfEffect_Distant,
    }

    [System.Serializable]
    public class AbilityInfoContainer
    {
        [SerializeField] private GameObject specialEffectsPrefab = default;
        [SerializeField] private TargetingType targetingType = default;
        [SerializeField] private int maxLevel = default;
        [Tooltip("Base Cooldown to use for level 1 of ability. We then apply the cooldown modifier per level.")]
        [SerializeField] private float cooldown = default;
        [Tooltip("This value will be assumed to be negative; however, if you would like to INCREASE the cooldown rate per level, provide a negative number.")]
        [SerializeField] private float cooldownModifier = default;

        public TargetingType TargetingType => targetingType;
        public GameObject Sfx => specialEffectsPrefab;
        public int MaxLevel => maxLevel; 
        public float Cooldown => cooldown; 
        public float CooldownModifier => cooldownModifier;

        //TODO Implement, or move elsewhere
        public AbilityBehavior AbilityBehavior { get; private set; }
    }
}