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
    

    //Attributes do not have direct getters. They are loaded into a list, then converted into an array and sent as a whole.
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
    private List<Attribute> attributes = new List<Attribute>();

    public void OnEnable()
    {
        Debug.Log("Initializing CharacterSheet");
        attributes[0] = new Attribute(AttributeType.Agility, baseAgiilityValue);
        attributes[1] = new Attribute(AttributeType.Strength, baseAgiilityValue);
        attributes[2] = new Attribute(AttributeType.Wisdom, baseAgiilityValue);
        attributes[3] = new Attribute(AttributeType.Endurance, baseAgiilityValue);
    }
    #endregion
    public Attribute[] Attributes { get => attributes.ToArray(); }
    public string CharacterName { get => characterName; }
    public string CharacterDescription { get => characterDescription; }
    public Sprite CharacterSprite { get => characterSprite; }
}
