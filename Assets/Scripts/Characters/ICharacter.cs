using System;
using UnityEngine;

public interface ICharacter
{
    string CharacterName { get; }
    string CharacterDescription { get; }
    Sprite CharacterSprite { get; }
    ICharacterAttributesHandler Attributes { get; }
    ICharacterLeague CharacterLeague { get; }
    IStatusEffectHandler StatusEffectHandler { get; }
    GameObject GameObject { get; }
    IHealth Health { get; }
    void Heal(int amount);
    event EventHandler<Character.HealedEventArgs> Healed;
}
