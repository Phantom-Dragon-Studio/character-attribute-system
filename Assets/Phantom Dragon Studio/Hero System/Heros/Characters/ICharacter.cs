using System;
using PhantomDragonStudio.Tools;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacter
    {
        ICharacterSheet CharacterSheet { get; }
        GeneralObjectInformation GeneralObjectInformation { get; }
        ICharacteristicController CharacteristicController { get; }
        IHealth Health { get; }
        void Heal(float amount);
        event EventHandler<HealedEventArgs> Healed;
        void Damage(float amount);
        Transform Transform { get; }
        event EventHandler<DamagedEventArgs> Damaged;
        ICharacter Construct(CharacteristicController characteristicController, Health health);
        void Die();
    }
}
