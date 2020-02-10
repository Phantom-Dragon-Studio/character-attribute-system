﻿using UnityEngine;
using UnityEngine.Serialization;

namespace PhantomDragonStudio.Ability_System
{
    [System.Serializable]
    public class AbilityInfo
    {
        [SerializeField] private int currentLevel = default;
        [SerializeField] private int maxLevel = default;
        [Tooltip("Base Cooldown to use for level 1 of ability. We then apply the cooldown modifier per level.")]
        [SerializeField] private float cooldown = default;
        [Tooltip("This value will be assumed to be negative; however, if you would like to INCREASE the cooldown rate per level, provide a negative number.")]
        [SerializeField] private float cooldownModifier = default;
        public int CurrentLevel { get => currentLevel; private set => currentLevel = value; }
        public int MaxLevel => maxLevel; 
        public float Cooldown => cooldown; 
        public float CooldownModifier => cooldownModifier;
        public void AdjustLevel(int amount)
        {
            CurrentLevel += amount;
        }
        public void EngageCooldown()
        {
            //Start Coroutine?
        }
        public void ResetCooldown()
        {
            cooldown = 0f;
        }
    }
}