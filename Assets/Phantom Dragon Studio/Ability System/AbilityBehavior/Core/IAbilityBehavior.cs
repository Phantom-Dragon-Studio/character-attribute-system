using UnityEngine;

namespace  PhantomDragonStudio.Ability_System
{
    public interface IAbilityBehavior 
    {
        void Construct(IAbility ability);

        void Execute();

        void Dispose();
    }
}
