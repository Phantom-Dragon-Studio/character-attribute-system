using UnityEngine;
using PhantomDragonStudio.PoolingSystem;

namespace PhantomDragonStudio.CombatMechanics.Projectiles
{
    public static class ProjectileFactory
    {
        public static IProjectile Create(Projectile projectile, ProjectilePool pool)
        {
            IProjectile newProjectile = GameObject.Instantiate(projectile);
            newProjectile.Initialize(projectile.Data, projectile.Behavior, pool);
            return newProjectile;
        }
    }
}