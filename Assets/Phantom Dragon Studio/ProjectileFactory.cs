using PhantomDragonStudio.Ability_System;
using UnityEngine;

namespace PhantomDragonStudio
{
    public static class ProjectileFactory
    {
        public static GameObject Create(GameObject projectile, Transform source)
        {
            GameObject newProjectile = GameObject.Instantiate(projectile, source.position, source.rotation, source.transform);
            return newProjectile;
        }
    }
}
