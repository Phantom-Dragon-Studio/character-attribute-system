using PhantomDragonStudio.CombatMechanics.Projectiles;
using PhantomDragonStudio.PoolingSystem;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Icebolt Ability", menuName = "Phantom Dragon Studio/Ability System/Abilities/Icebolt Ability", order = 1)]
    public class Icebolt_Ability : BaseAbility
    {
        [SerializeField] private StatusEffect[] statusEffects = default;
        [SerializeField] private ProjectilePool projectilePool = default;
        [SerializeField] private Vector3 offset;
        private IProjectile projectile;
        
        public override void Cast()
        {  
            // Debug.Log(AbilityInformation.GeneraInformation.Name + " is casting!");
            var casterTransform = Caster.transform;
            base.Cast();
            projectile = projectilePool.RemoveFromPool();
            projectile.Transform.position = casterTransform.position;
            projectile.Transform.rotation = casterTransform.rotation;
            projectile.Activate();
        }
    }
}
