using System;
using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacter
    {
        ICharacterSheet CharacterSheet { get; }
        GeneralObjectInformation GeneralObjectInformation { get; }
        ICharacteristicController CharacteristicController { get; }
        ICharacter Construct(CharacteristicController characteristicController, Health health);
        void Heal(float amount);
        event EventHandler<Character.HealedEventArgs> Healed;
        IHealth Health { get; }
    }
}
