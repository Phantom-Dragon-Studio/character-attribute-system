using UnityEngine;
/// <summary>
/// This class is the base class for all units. Classes such as the Hero class inherit from this class.
/// </summary>
[System.Serializable]
public class Unit : MonoBehaviour, IUnit
{
    [SerializeField] private CharacterSheet characterSheet;

    private ICharacterAttributes characterAttributes;


    public string CharacterName => characterSheet.CharacterName;
    public string CharacterDescription => characterSheet.CharacterDescription;
    public Sprite CharacterSprite => characterSheet.CharacterSprite;
    public ICharacterAttributes GetAttributes => characterAttributes;

    public Unit(CharacterSheet sheet, ICharacterAttributes characterStats)
    {
        this.characterSheet = sheet;
        this.characterAttributes = characterStats;
    }

    //public Unit(CharacterSheet sheet)
    //{
    //    this.characterSheet = sheet;
    //    this.characterAttributes = new CharacterAttributes(characterSheet.Attributes.ToArray());
    //}

    protected virtual void Awake()
    {
        //characterAttributes must have a new instance initialized in awake.
        //If this line is moved into the contructor then preplaced objects whom are not created using the constructor
        //will have a null value assigned to characterAttributes.
        this.characterAttributes = new CharacterAttributes(characterSheet.Attributes);
    }
}
