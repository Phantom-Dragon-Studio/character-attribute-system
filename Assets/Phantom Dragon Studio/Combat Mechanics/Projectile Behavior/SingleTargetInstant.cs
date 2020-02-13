using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    [CreateAssetMenu(fileName = "New Instant Projectile Behavior", menuName = "Phantom Dragon Studio/Ability System/Single Target Instant Behavior")]

    public class SingleTargetInstant : ProjectileBehavior, IProjectileBehavior
    { 
        public void Construct(Projectile projectile)
        {
            //Gather necessary information to complete behavior.
            Debug.Log("AbilityBehavior_SingleTargetMissile: Constructing");
        }

        public void Perform()
        {
                //Do stuff with info we have
            Debug.Log("AbilityBehavior_SingleTargetMissile: Executing");
        }

        public void End()
        {
            //Clean up
            Debug.Log("AbilityBehavior_SingleTargetMissile: Dispose");
            //TODO Remove projectile behavior? Behavior can probably go on the projectile script themselves. Reevaluate architecture.
        }
    }
}