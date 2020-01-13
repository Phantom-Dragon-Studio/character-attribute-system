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
}
