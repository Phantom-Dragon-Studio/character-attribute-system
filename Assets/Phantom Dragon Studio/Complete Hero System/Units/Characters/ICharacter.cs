using System;
using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacter
    {
        ICharacterSheet CharacterSheet { get; }
        GeneralObjectInformation GeneralObjectInformation { get; }
        ICombatController CombatController { get; }
        ICharacter Construct(CombatController combatController, Health health);
        void Heal(float amount);
        event EventHandler<Character.HealedEventArgs> Healed;
    }
}
