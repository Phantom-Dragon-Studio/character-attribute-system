using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Sheet", menuName = "Phantom Dragon Studio/New Character Sheet", order = 0)]
public class CharacterSheet : ScriptableObject
{
    [Header("General Information")]
    [SerializeField] private string characterName;
    [SerializeField] private string characterDescription;
    [SerializeField] private Sprite characterSprite;
    

    //Attributes do not have direct getters. They are loaded into an array and sent as a whole.
    //The SO is setup in this manner to allow explicit attribute base values to be assigned without needing to write a custom inspector.
    [Header("Agility")]
    [SerializeField] private float baseAgiilityValue;
    [Header("Strength")]
    [SerializeField] private float baseStrengthValue;
    [Header("Wisdom")]
    [SerializeField] private float baseWisdomValue;
    [Header("Endurance")]
    [SerializeField] private float baseEnduranceValue;



    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    #region Initialization

    private CharacterAttributeFactory characterAttributeFactory => new CharacterAttributeFactory();
    private ICharacterAttribute[] attributes = new ICharacterAttribute[Enum.GetNames(typeof(AttributeType)).Length];

    public void OnEnable()
    {
        Debug.Log("Initializing CharacterSheet for " + CharacterName);
        attributes[0] = characterAttributeFactory.Create(AttributeType.Agility, baseAgiilityValue);
        attributes[1] = characterAttributeFactory.Create(AttributeType.Strength, baseStrengthValue);
        attributes[2] = characterAttributeFactory.Create(AttributeType.Wisdom, baseWisdomValue);
        attributes[3] = characterAttributeFactory.Create(AttributeType.Endurance, baseEnduranceValue);
    }
    #endregion

    public ICharacterAttribute[] Attributes { get => attributes; }
    public string CharacterName { get => characterName; }
    public string CharacterDescription { get => characterDescription; }
    public Sprite CharacterSprite { get => characterSprite; }
}
