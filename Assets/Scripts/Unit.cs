using UnityEngine;

[System.Serializable]
public class Unit : MonoBehaviour, IUnit
{
    [SerializeField] private CharacterSheet characterSheet;

    private CharacterAttributes characterAttributes;


    public string CharacterName => characterSheet.CharacterName;
    public string CharacterDescription => characterSheet.CharacterDescription;
    public Sprite CharacterSprite => characterSheet.CharacterSprite;
    public IAttribute GetAttributes => characterAttributes;

    public Unit(CharacterSheet sheet, CharacterAttributes characterStats)
    {
        this.characterSheet = sheet;
        this.characterAttributes = characterStats;
    }

    //public Unit(CharacterSheet sheet)
    //{
    //    this.characterSheet = sheet;
    //    this.characterAttributes = new CharacterAttributes(characterSheet.Attributes.ToArray());
    //}

    void Awake()
    {
        //characterAttributes must have a new instance initialized in awake.
        //If this line is moved into the contructor then preplaced objects whom are not created using the constructor
        //will have a null value assigned to characterAttributes.
        this.characterAttributes = new CharacterAttributes(characterSheet.Attributes);
    }
}
