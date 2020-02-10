using System;
using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Ability_System;
using UnityEngine;

namespace PhantomDragonStudio
{
    public interface IProjectile
    {
        void Initialize(float _speed, ProjectileBehavior_SingleTargetMissile behavior);
        ProjectileData Data { get; }
    }
}
