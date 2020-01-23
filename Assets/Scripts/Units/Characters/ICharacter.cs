using System;
using UnityEngine;

public interface ICharacter
{
    ICharacterSheet CharacterSheet { get; }
    GeneralObjectInformation GeneralObjectInformation { get; }

    ICombatController CombatController { get; }

    ICharacterLeague League { get; }


    void Heal(float amount);
    event EventHandler<Character.HealedEventArgs> Healed;
}
