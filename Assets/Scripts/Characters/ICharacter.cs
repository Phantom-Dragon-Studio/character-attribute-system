using UnityEngine;

public interface ICharacter
{
    string CharacterName { get; }
    string CharacterDescription { get; }
    Sprite CharacterSprite { get; }
    ICharacterAttributesHandler Attributes { get; }
    ICharacterClass CharacterClass { get; }
}
