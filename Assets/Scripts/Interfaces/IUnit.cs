using UnityEngine;

public interface IUnit
{
    string CharacterName { get; }
    string CharacterDescription { get; }
    Sprite CharacterSprite { get; }
    ICharacterAttributesHandler GetAttributes { get; }
}
