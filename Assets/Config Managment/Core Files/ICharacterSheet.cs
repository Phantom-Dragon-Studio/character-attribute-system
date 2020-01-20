using UnityEngine;

public interface ICharacterSheet
{
    ICharacterAttribute[] Attributes { get; }
    string CharacterName { get; }
    string CharacterDescription { get; }
    Sprite CharacterSprite { get; }
    ICharacterLeague CharacterLeague { get; }

    void OnEnable();
}
