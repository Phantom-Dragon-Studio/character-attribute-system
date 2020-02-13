using UnityEngine;
using PhantomDragonStudio;
using PhantomDragonStudio.Ability_System;

namespace PhantomDragonStudio.CombatMechanics
{
    public static class ProjectileFactory
    {
        public static IProjectile Create(Projectile projectile, ProjectilePool pool)
        {
            IProjectile newProjectile = GameObject.Instantiate(
                projectile);
            newProjectile.Initialize(projectile.Data, projectile.Behavior, pool);
            return newProjectile;
        }
    }
}