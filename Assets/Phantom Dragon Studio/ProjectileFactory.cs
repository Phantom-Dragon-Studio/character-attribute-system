using UnityEngine;
using PhantomDragonStudio;
using PhantomDragonStudio.Ability_System;

namespace PhantomDragonStudio
{
    public static class ProjectileFactory
    {
        //TODO Convert this to ProjectileData Sheets
        public static IProjectile Create(Projectile projectile)
        {
            Debug.Log(projectile);
            IProjectile newProjectile = GameObject.Instantiate(
                projectile);
            newProjectile.Initialize(projectile.Data.Speed, projectile.Behavior);
            return newProjectile;
        }
    }
}