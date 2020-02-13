using System;
using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Ability_System;
using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    public interface IProjectile
    {
        void Initialize(ProjectileData _projectileData, SingleTargetMissile _behavior, ProjectilePool poolToUse);
        ProjectileData Data { get; }
        
        Transform Transform { get; }
        Rigidbody Rigidbody { get; }

        void Activate();
        void Deactivate();
    }
}
