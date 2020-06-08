using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.CombatMechanics
{
    public interface IHealthMechanics : IHealable, IDamageable, IKillable
    {
        CharacterHealth Health { get; }
    }
}
