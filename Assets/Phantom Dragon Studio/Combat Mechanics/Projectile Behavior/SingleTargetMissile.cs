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
            data = _projectile.Data;
            projectile = _projectile;
            projectileTransform = projectile.Transform;
        }

        public void Perform()
        {
            projectile.Rigidbody.AddForce(Vector3.forward * data.Speed);
        }
        
        public void End()
        {
            Debug.Log("SingleTargetMissile: Dispose");
        }
    }
}
