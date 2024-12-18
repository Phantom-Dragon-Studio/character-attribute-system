﻿using System.Collections;

namespace  PhantomDragonStudio.CombatMechanics.Projectiles
{
    public interface IProjectileBehavior 
    {
        void Construct(IProjectile projectile);

        void Perform(IProjectile projectile);

        void End(IProjectile projectile);
    }
}
