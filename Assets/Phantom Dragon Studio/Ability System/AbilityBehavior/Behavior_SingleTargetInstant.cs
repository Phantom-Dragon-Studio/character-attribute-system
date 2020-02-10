using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Instant Ability Behavior", menuName = "Phantom Dragon Studio/Ability System/Single Target Instant Behavior")]

    public class Behavior_SingleTargetInstant : ProjectileBehavior, IProjectileBehavior
    {
        public void Construct()
        {
            Debug.Log("AbilityBehavior_SingleTargetMissile: Constructing");
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public override void Dispose()
        {
            Debug.Log("AbilityBehavior_SingleTargetMissile: Dispose");
        }

        public void Execute(ProjectileData data)
        {
            Debug.Log("AbilityBehavior_SingleTargetMissile: Executing");
            //TODO Pull projectile from pool and assign it the correct values via Initialize().
            //
        }
    }
}