using System;
using UnityEngine;

public interface ICharacter
{
    GeneralObjectInformation GeneralObjectInformation { get; }
    ICharacterLeague League { get; }
    ICharacterSheet CharacterSheet { get; }
    void Heal(float amount);
    event EventHandler<Character.HealedEventArgs> Healed;
}
