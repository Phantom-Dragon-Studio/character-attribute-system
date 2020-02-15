using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    [CreateAssetMenu(fileName ="New Add Force Forward Behavior", menuName ="Phantom Dragon Studio/Combat Mechanics/Projectile Behaviors/Add Force Forward")]

    public class AddForceForward_Behavior : ProjectileBehavior
    {
        [SerializeField] private bool affectedByGravity = false;
        private ProjectileData data;
        public bool AffectedByGravity => affectedByGravity;
        public override void Construct(IProjectile _projectile)
        {

        }

        public override void Perform(IProjectile performingProjectile)
        {
            // Debug.Log(performingProjectile.Transform.GetInstanceID().ToString() + " is performing behavior!");
            performingProjectile.Rigidbody.AddForce(Vector3.forward * performingProjectile.Data.Speed);
        }
        
        public override void End(IProjectile performingProjectile)
        {
            performingProjectile.Deactivate();
            performingProjectile.Rigidbody.velocity = Vector3.zero;
            performingProjectile.Rigidbody.angularVelocity = Vector3.zero; 
        }
    }
}
