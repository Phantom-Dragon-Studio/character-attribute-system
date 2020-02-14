using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    [CreateAssetMenu(fileName ="New Projectile Behavior", menuName ="Phantom Dragon Studio/Ability System/Single Target Behavior")]

    public class SingleTargetMissile : ProjectileBehavior, IProjectileBehavior
    {
        [SerializeField] private bool affectedByGravity = false;
        private ProjectileData data;
        private IProjectile projectile;
        private Transform projectileTransform;
        public bool AffectedByGravity => affectedByGravity;
        public void Construct(Projectile _projectile)
        {
            projectile = _projectile;
            data = projectile.Data;
            // projectileTransform = projectile.Transform;
        }

        public void Perform(IProjectile performingProjectile)
        {
            Debug.Log(performingProjectile.GetHashCode().ToString() + " is performing behavior!");
            performingProjectile.Rigidbody.AddForce(Vector3.forward * performingProjectile.Data.Speed);
        }
        
        public void End()
        {
            projectile.Deactivate();
            projectile.Rigidbody.velocity = Vector3.zero;
            projectile.Rigidbody.angularVelocity = Vector3.zero; 
        }
    }
}
