using System;
using PhantomDragonStudio.PoolingSystem;
using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics.Projectiles
{
    public interface IProjectile
    {
        event EventHandler<ProjectileCollisionEventArgs> Collided;
        void Initialize(ProjectileData _projectileData, ProjectileBehavior _behavior, ProjectilePool poolToUse);
        ProjectileData Data { get; }
        Transform Transform { get; }
        Rigidbody Rigidbody { get; }
        int GetInstanceID();
        void Activate();
        void Deactivate();
    }
}
