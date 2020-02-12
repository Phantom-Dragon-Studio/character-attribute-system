using System;
using PhantomDragonStudio.Tools;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacter
    {
        ICharacterSheet CharacterSheet { get; }
        GeneralObjectInformation GeneralObjectInformation { get; }
        ICharacteristicController CharacteristicController { get; }
        ICharacter Construct(CharacteristicController characteristicController, Health health);
        IHealth Health { get; }
        void Heal(float amount);
        event EventHandler<Character.HealedEventArgs> Healed;
        void Damage(float amount);
        event EventHandler<Character.DamagedEventArgs> Damaged;
    }
}
