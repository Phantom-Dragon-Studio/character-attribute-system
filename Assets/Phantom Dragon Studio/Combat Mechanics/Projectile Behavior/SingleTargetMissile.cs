using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    [CreateAssetMenu(fileName ="New Projectile Behavior", menuName ="Phantom Dragon Studio/Ability System/Single Target Behavior")]

    public class SingleTargetMissile : ProjectileBehavior, IProjectileBehavior
    {
        [SerializeField] private bool affectedByGravity = false;
        private ProjectileData data;
        public bool AffectedByGravity => affectedByGravity;
        public void Construct(IProjectile _projectile)
        {

        }

        public void Perform(IProjectile performingProjectile)
        {
            Debug.Log(performingProjectile.Transform.GetInstanceID().ToString() + " is performing behavior!");
            performingProjectile.Rigidbody.AddForce(Vector3.forward * performingProjectile.Data.Speed);
        }
        
        public void End(IProjectile performingProjectile)
        {
            performingProjectile.Deactivate();
            performingProjectile.Rigidbody.velocity = Vector3.zero;
            performingProjectile.Rigidbody.angularVelocity = Vector3.zero; 
        }
    }
}
