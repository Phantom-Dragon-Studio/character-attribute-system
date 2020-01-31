using PhantomDragonStudio.Ability_System;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    public abstract class AbilityBehavior : ScriptableObject
    {
        AbilityInformation _abilityInformation;
        public AbilityInformation AbilityInformation { get => this._abilityInformation; set { this._abilityInformation = value; }  }

        public abstract void Construct();

        public abstract void Execute();

        public abstract void Dispose();
    }
}
