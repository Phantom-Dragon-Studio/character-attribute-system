using System;

namespace PhantomDragonStudio.CombatMechanics
{
    public interface IHealable
    {
        void RestoreHealth(float amount);

        event EventHandler<HealedEventArgs> Healed;
    }
}
