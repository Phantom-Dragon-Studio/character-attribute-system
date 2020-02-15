using System;
using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Ability_System;
using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    public interface IProjectile
    {
        void Initialize(ProjectileData _projectileData, ProjectileBehavior _behavior, ProjectilePool poolToUse);
        event EventHandler<ProjectileCollisionEventArgs> Collided;
        ProjectileData Data { get; }
        Boolean HasCollided { get; }
        Transform Transform { get; }
        Rigidbody Rigidbody { get; }
        int GetInstanceID();
        void Activate();
        void Deactivate();
    }
}
