using PhantomDragonStudio.Ability_System;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    //[CreateAssetMenu(fileName ="New Ability Behavior", menuName ="Phantom Dragon Studio/Ability System/Ability Behavior")]

    public abstract class AbilityBehavior : ScriptableObject, IAbilityBehavior
    {
        protected IAbility ability;
        public abstract IAbility Ability { get; set; }

        public abstract void Construct(IAbility ability);

        public abstract void Execute();

        public abstract void Dispose();
    }
}
