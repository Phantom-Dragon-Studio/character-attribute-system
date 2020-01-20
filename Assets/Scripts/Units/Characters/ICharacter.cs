using System;
using UnityEngine;

public interface ICharacter
{
    string CharacterName { get; }
    string CharacterDescription { get; }
    Sprite CharacterSprite { get; }
    ICharacterAttributesHandler Attributes { get; }
    IStatusEffectHandler StatusEffectHandler { get; }

    IHealth Health { get; }
    void Heal(float amount);
    event EventHandler<Character.HealedEventArgs> Healed;
}
