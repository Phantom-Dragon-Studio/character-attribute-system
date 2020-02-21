using System;

namespace PhantomDragonStudio.CombatMechanics
{
    public interface IDamageable
    {
        void TakeDamage(float amount);

        event EventHandler<DamagedEventArgs> Damaged;
    }
}