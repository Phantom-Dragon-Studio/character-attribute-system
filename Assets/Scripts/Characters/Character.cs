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
    private ICharacterLeague characterLeague;

    public string CharacterName => characterSheet.CharacterName;
    public string CharacterDescription => characterSheet.CharacterDescription;
    public Sprite CharacterSprite => characterSheet.CharacterSprite;

    public ICharacterAttributesHandler Attributes => characterAttributes;
    public ICharacterLeague CharacterLeague => characterSheet.CharacterLeague;

    private void Awake()
    {
        this.characterAttributes = CharacterAttributesHandlerFactory.Create(characterSheet.Attributes);
    }
}
