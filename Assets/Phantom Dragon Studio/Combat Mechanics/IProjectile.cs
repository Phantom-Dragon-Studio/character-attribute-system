using System;
using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Ability_System;
using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    public interface IProjectile
    {
        void Initialize(ProjectileData data, SingleTargetMissile behavior);
        ProjectileData Data { get; }
    }
}
