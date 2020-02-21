using System;
using PhantomDragonStudio.CombatMechanics;

public interface ICollidable 
{
    event EventHandler<ProjectileCollisionEventArgs> Collided;
}
