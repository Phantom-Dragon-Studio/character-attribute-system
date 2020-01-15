using System;
using UnityEngine;
/// <summary>
///     Main Data Container for characters
///  Attributes do not have direct getters. They are loaded into an array and sent as a whole.
///  The SO is setup in this manner to allow explicit attribute base values to be assigned without needing to write a custom inspector.
/// </summary>
[CreateAssetMenu(fileName = "New Character Sheet", menuName = "Phantom Dragon Studio/Character Sheet", order = 0)]
public class CharacterSheet : ScriptableObject
{
    [Header("General Information")]
    [SerializeField] private GeneralObjectInformation objectInformation = default;
    [SerializeField] private ICharacterLeague characterLeague = default;

    [Header("Agility")]
    [SerializeField] private float baseAgiilityValue = default;
    [Header("Strength")]
    [SerializeField] private float baseStrengthValue = default;
    [Header("Wisdom")]
    [SerializeField] private float baseWisdomValue = default;
    [Header("Endurance")]
    [SerializeField] private float baseEnduranceValue = default;
    [SerializeField] private GameObject prefab = default;


    //Public Accessors
    public ICharacterAttribute[] Attributes { get => attributes; }
    public string CharacterName { get => objectInformation.Name; }
    public string CharacterDescription { get => objectInformation.Description; }
    public Sprite CharacterSprite { get => objectInformation.Sprite; }
    public ICharacterLeague CharacterLeague { get => characterLeague; set => characterLeague = value; }
    public GameObject Prefab { get => prefab; }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    #region Initialization

    //NOTE: The "-1" at the end of the array length declaration is mandatory as we have a 'None' field available in attributes which is utilized by
    //The StatusEffects system incase we do not want to have a status effect attached to a spell action, etc. 

    private ICharacterAttribute[] attributes = new ICharacterAttribute[Enum.GetNames(typeof(AttributeType)).Length - 1];

    public void OnEnable()
    {
        Debug.Log("Initializing ICharacterSheet for " + CharacterName);
        attributes[0] = CharacterAttributeFactory.Create(AttributeType.Agility, baseAgiilityValue);
        attributes[1] = CharacterAttributeFactory.Create(AttributeType.Strength, baseStrengthValue);
        attributes[2] = CharacterAttributeFactory.Create(AttributeType.Wisdom, baseWisdomValue);
        attributes[3] = CharacterAttributeFactory.Create(AttributeType.Endurance, baseEnduranceValue);
    }
    #endregion
}
