using System;
using UnityEngine;
/// <summary>
/// This class is the base class for all units. Classes such as the Hero class inherit from this class.
/// </summary>
[System.Serializable]
public class Character : MonoBehaviour, ICharacter
{
    [SerializeField] private CharacterSheet characterSheet;

    private ICharacterAttributesHandler characterAttributes;
    private ICharacterClass characterClass;

    public string CharacterName => characterSheet.CharacterName;
    public string CharacterDescription => characterSheet.CharacterDescription;
    public Sprite CharacterSprite => characterSheet.CharacterSprite;

    public ICharacterAttributesHandler GetAttributes => characterAttributes;
    public ICharacterClass CharacterClass => characterSheet.CharacterClass;

    private void Awake()
    {
        this.characterAttributes = CharacterAttributesHandlerFactory.Create(characterSheet.Attributes);
    }
}
