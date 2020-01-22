using System;
using UnityEngine;

public interface ICharacter
{
    GeneralObjectInformation GeneralObjectInformation { get; }
    ICharacterAttributesHandler Attributes { get; }
    ICharacterLeague League { get; }

    IHealth Health { get; }
    void Heal(float amount);
    event EventHandler<Character.HealedEventArgs> Healed;
}
