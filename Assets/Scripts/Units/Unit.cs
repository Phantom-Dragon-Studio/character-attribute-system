using UnityEngine;
/// <summary>
/// This class is the base class for all units. Classes such as the Hero class inherit from this class.
/// </summary>
[System.Serializable]
public class Unit : MonoBehaviour, IUnit
{
    [SerializeField] private CharacterSheet characterSheet;

    private ICharacterAttributesHandler characterAttributes;
    private CharacterAttributesHandlerFactory _characterAttributesFactory => new CharacterAttributesHandlerFactory();

    public string CharacterName => characterSheet.CharacterName;
    public string CharacterDescription => characterSheet.CharacterDescription;
    public Sprite CharacterSprite => characterSheet.CharacterSprite;
    public ICharacterAttributesHandler GetAttributes => characterAttributes;

    public Unit(CharacterSheet sheet)
    {
        this.characterSheet = sheet;
    }

    private void Awake()
    {
        this.characterAttributes = _characterAttributesFactory.Create(characterSheet.Attributes);
    }
}
