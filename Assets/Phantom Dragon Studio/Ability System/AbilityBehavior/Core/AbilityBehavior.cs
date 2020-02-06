﻿using PhantomDragonStudio.Ability_System;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    //[CreateAssetMenu(fileName ="New Ability Behavior", menuName ="Phantom Dragon Studio/Ability System/Ability Behavior")]

    public abstract class AbilityBehavior : ScriptableObject, IAbilityBehavior
    {
        Ability _abilityInformation;
        public Ability AbilityInformation { get => this._abilityInformation; set { this._abilityInformation = value; }  }

        public abstract void Construct();

        public abstract void Execute();

        public abstract void Dispose();
    }
}