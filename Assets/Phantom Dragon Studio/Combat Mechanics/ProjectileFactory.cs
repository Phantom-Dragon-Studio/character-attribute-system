using UnityEngine;
using PhantomDragonStudio;
using PhantomDragonStudio.Ability_System;

namespace PhantomDragonStudio.CombatMechanics
{
    public static class ProjectileFactory
    {
        //TODO Convert this to ProjectileData Sheets
        public static IProjectile Create(Projectile projectile)
        {
            IProjectile newProjectile = GameObject.Instantiate(
                projectile);
            newProjectile.Initialize(projectile.Data.Speed, projectile.Behavior);
            return newProjectile;
        }
    }
}