using System;
using PhantomDragonStudio.CombatMechanics;

public interface ICollisionHandler 
{
    event EventHandler<ProjectileCollisionEventArgs> Collided;
}
