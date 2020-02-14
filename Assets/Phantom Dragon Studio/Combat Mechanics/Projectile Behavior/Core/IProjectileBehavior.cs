using System.Collections;

namespace  PhantomDragonStudio.CombatMechanics
{
    public interface IProjectileBehavior 
    {
        void Construct(Projectile projectile);

        void Perform(IProjectile projectile);

        void End();
    }
}
