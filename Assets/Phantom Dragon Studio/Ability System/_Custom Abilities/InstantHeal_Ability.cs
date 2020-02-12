﻿using System;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Instant Heal Ability", menuName = "Phantom Dragon Studio/Ability System/Abilities/Instant Heal Ability", order = 1)]
    public class InstantHeal_Ability : BaseAbility
    {
        [SerializeField] private StatusEffect[] statusEffects = default;
        public StatusEffect[] StatusEffects => statusEffects;

        public override void Cast()
        {
            base.Cast();
            Debug.Log(this.name + " is executing CAST OVERRIDE!");
        }
    }
}
