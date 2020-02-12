using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    [CreateAssetMenu(fileName ="New Projectile Behavior", menuName ="Phantom Dragon Studio/Ability System/Single Target Behavior")]

    public class SingleTargetMissile : ProjectileBehavior, IProjectileBehavior
    {
        private ProjectileData data;
        [SerializeField] private bool affectedByGravity = false;
        public bool AffectedByGravity { get => affectedByGravity; set => affectedByGravity = value; }
        public void Construct(ProjectileData data)
        {
            // Debug.Log("SingleTargetMissile: Constructing");
        }

        public void Execute()
        {
           Debug.Log("SingleTargetMissile: Executing");
           //TODO Pull projectile from pool and assign it the correct values via Initialize().
           //
        }
        
        public override void Dispose()
        {
            Debug.Log("SingleTargetMissile: Dispose");
        }
    }
}
